/*
  Regulation de remplissage : Arduino Mega 2560 + Raspberry Pi par USB.
  Capteur HC-SR04 sur la Mega. Aucune bibliotheque Arduino supplementaire.
  Supervision : supervision_cuve.py, liaison 115200 bauds, lignes terminees par LF.
  Premiere mise sous tension : mode STOP, relais au repos.
  Lire README_FR.md avant de brancher la pompe.
*/
#include <Arduino.h>
#include <math.h>
#include <stdlib.h>
#include <string.h>

// ---------------- Parametres a adapter AVANT utilisation ----------------
const uint8_t TRIG_PIN = 22;
const uint8_t ECHO_PIN = 23;
const uint8_t RELAY_PIN = 24;
const uint8_t HIGH_FLOAT_PIN = 26;
const bool RELAY_ACTIVE_LOW = true;  // true : entree IN a LOW = pompe commandee
const bool USE_HIGH_FLOAT = false;  // true si flotteur NC installe sur D26/GND

// Distances depuis la face du capteur, pas les dimensions exterieures de la cuve.
// Exemple : cuve vide = 120 cm ; niveau utile maximal = 20 cm du capteur.
const float EMPTY_DISTANCE_CM = 120.0f;
const float FULL_DISTANCE_CM = 20.0f;
const unsigned long MAX_FILL_MS = 120000UL;  // 2 min pour la maquette : adapter
const unsigned long LINK_TIMEOUT_MS = 5000UL;
const unsigned long SAMPLE_MS = 300UL;
const unsigned long STATUS_MS = 500UL;
const unsigned long ECHO_TIMEOUT_US = 25000UL;
const uint8_t GOOD_SAMPLES_REQUIRED = 3;

enum Mode { STOPPED, AUTOMATIC, MANUAL };
enum Fault { NONE, SENSOR, HIGH_FLOAT, FILL_TIMEOUT, LINK_LOST, CONFIG };
Mode mode = STOPPED;
Fault fault = NONE;
bool pumpOn = false;
bool manualRequest = false;
bool sensorReady = false;
bool heartbeatSeen = false;
bool configurationOK = false;
uint8_t goodSamples = 0;
uint8_t lowPercent = 20;
uint8_t highPercent = 90;
float levelPercent = NAN;
float distanceCm = NAN;
unsigned long lastSampleMs = 0;
unsigned long lastStatusMs = 0;
unsigned long lastHeartbeatMs = 0;
unsigned long pumpStartedMs = 0;
char commandBuffer[80];
uint8_t commandLength = 0;
bool discardCommand = false;

bool floatIsOpen() {
  // INPUT_PULLUP : contact FERME vers GND au repos ; OUVERT = haut/fil coupe.
  return USE_HIGH_FLOAT && digitalRead(HIGH_FLOAT_PIN) == HIGH;
}

bool linkIsFresh(unsigned long now) {
  return heartbeatSeen && (unsigned long)(now - lastHeartbeatMs) < LINK_TIMEOUT_MS;
}

void setPump(bool requested) {
  if (requested && !pumpOn) pumpStartedMs = millis();
  pumpOn = requested;
  const uint8_t active = RELAY_ACTIVE_LOW ? LOW : HIGH;
  digitalWrite(RELAY_PIN, requested ? active : (active == LOW ? HIGH : LOW));
}

void stopSystem() {
  setPump(false);
  manualRequest = false;
  mode = STOPPED;
}

void trip(Fault reason) {
  if (fault == NONE) fault = reason;  // Conserver la premiere cause.
  stopSystem();
}

const char* modeName() {
  if (mode == AUTOMATIC) return "AUTO";
  if (mode == MANUAL) return "MANUAL";
  return "STOP";
}

const char* alarmName() {
  switch (fault) {
    case SENSOR: return "SENSOR";
    case HIGH_FLOAT: return "HIGH_FLOAT";
    case FILL_TIMEOUT: return "FILL_TIMEOUT";
    case LINK_LOST: return "LINK_LOST";
    case CONFIG: return "CONFIG";
    default: return sensorReady ? "NONE" : "NOT_READY";
  }
}

void sendStatus() {
  // JSON produit avec Serial.print pour eviter String/ArduinoJson sur AVR.
  Serial.print(F("{\"type\":\"status\",\"ms\":")); Serial.print(millis());
  Serial.print(F(",\"mode\":\"")); Serial.print(modeName());
  Serial.print(F("\",\"pump\":")); Serial.print(pumpOn ? 1 : 0);
  Serial.print(F(",\"valid\":")); Serial.print(sensorReady ? 1 : 0);
  Serial.print(F(",\"level\":"));
  if (sensorReady) Serial.print(levelPercent, 1); else Serial.print(F("null"));
  Serial.print(F(",\"distance_cm\":"));
  if (sensorReady) Serial.print(distanceCm, 1); else Serial.print(F("null"));
  Serial.print(F(",\"low\":")); Serial.print(lowPercent);
  Serial.print(F(",\"high\":")); Serial.print(highPercent);
  Serial.print(F(",\"alarm\":\"")); Serial.print(alarmName());
  Serial.println(F("\"}"));
}

void sampleLevel() {
  digitalWrite(TRIG_PIN, LOW);
  delayMicroseconds(2);
  digitalWrite(TRIG_PIN, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIG_PIN, LOW);
  const unsigned long duration = pulseIn(ECHO_PIN, HIGH, ECHO_TIMEOUT_US);
  const float measured = duration * 0.0343f / 2.0f;
  const bool valid = duration != 0 && measured >= 2.0f && measured <= 400.0f
                     && measured <= EMPTY_DISTANCE_CM + 10.0f;
  if (!valid) {
    goodSamples = 0;
    sensorReady = false;
    distanceCm = levelPercent = NAN;
    if (mode != STOPPED || pumpOn) trip(SENSOR);
    return;
  }
  distanceCm = measured;
  levelPercent = 100.0f * (EMPTY_DISTANCE_CM - measured)
                 / (EMPTY_DISTANCE_CM - FULL_DISTANCE_CM);
  if (levelPercent < 0.0f) levelPercent = 0.0f;
  if (levelPercent > 100.0f) levelPercent = 100.0f;
  if (goodSamples < GOOD_SAMPLES_REQUIRED) ++goodSamples;
  sensorReady = goodSamples >= GOOD_SAMPLES_REQUIRED;
}

bool canArm() {
  if (fault != NONE) { Serial.println(F("ERR FAULT_RESET_REQUIRED")); return false; }
  if (!sensorReady) { Serial.println(F("ERR SENSOR_NOT_READY")); return false; }
  if (floatIsOpen()) { trip(HIGH_FLOAT); Serial.println(F("ERR HIGH_FLOAT")); return false; }
  if (!linkIsFresh(millis())) { Serial.println(F("ERR NO_HEARTBEAT")); return false; }
  return true;
}

void handleCommand(const char* command) {
  if (strcmp(command, "PING") == 0) {
    lastHeartbeatMs = millis();
    heartbeatSeen = true;
    return;
  }
  if (strcmp(command, "STATUS") == 0) { sendStatus(); return; }
  if (strcmp(command, "STOP") == 0) {
    stopSystem();
  } else if (strcmp(command, "RESET") == 0) {
    stopSystem();  // Un rearmement ne fait jamais repartir la pompe.
    if (!configurationOK || !sensorReady || floatIsOpen() || !linkIsFresh(millis())) {
      Serial.println(F("ERR RESET_CONDITIONS")); return;
    }
    fault = NONE;
  } else if (strcmp(command, "AUTO") == 0 || strcmp(command, "MANUAL") == 0) {
    if (!canArm()) return;
    stopSystem();
    mode = strcmp(command, "AUTO") == 0 ? AUTOMATIC : MANUAL;
  } else if (strcmp(command, "ON") == 0) {
    if (mode != MANUAL) { Serial.println(F("ERR SELECT_MANUAL")); return; }
    if (!canArm()) return;
    if (levelPercent >= highPercent) { Serial.println(F("ERR LEVEL_HIGH")); return; }
    manualRequest = true;
  } else if (strcmp(command, "OFF") == 0) {
    if (mode != MANUAL) { Serial.println(F("ERR SELECT_MANUAL")); return; }
    manualRequest = false;
    setPump(false);
  } else if (strncmp(command, "SET ", 4) == 0) {
    if (mode != STOPPED) { Serial.println(F("ERR STOP_BEFORE_SET")); return; }
    char* end = NULL;
    const char* start = command + 4;
    const long low = strtol(start, &end, 10);
    if (end == start || *end != ' ' || low < 1 || low > 95) {
      Serial.println(F("ERR THRESHOLDS_1_TO_95_GAP_3")); return;
    }
    start = end + 1;
    const long high = strtol(start, &end, 10);
    while (*end == ' ') ++end;
    if (end == start || *end != '\0' || high < 1 || high > 95 || high - low < 3) {
      Serial.println(F("ERR THRESHOLDS_1_TO_95_GAP_3")); return;
    }
    lowPercent = (uint8_t)low;
    highPercent = (uint8_t)high;
  } else {
    Serial.println(F("ERR UNKNOWN_COMMAND")); return;
  }
  // L'etat confirme est publie par controlSystem() puis sendStatus() dans loop().
  Serial.print(F("ACK ")); Serial.println(command);
  lastStatusMs = millis() - STATUS_MS;
}

void receiveCommands() {
  uint8_t budget = 128;  // Une entree serie bavarde ne bloque pas la regulation.
  while (Serial.available() && budget--) {
    const char c = (char)Serial.read();
    if (c == '\r') continue;
    if (c == '\n') {
      if (discardCommand) Serial.println(F("ERR INVALID_OR_LONG_LINE"));
      else if (commandLength != 0) {
        commandBuffer[commandLength] = '\0';
        handleCommand(commandBuffer);
      }
      commandLength = 0;
      discardCommand = false;
    } else if ((uint8_t)c < 32 || (uint8_t)c > 126) {
      discardCommand = true;
    } else if (!discardCommand) {
      if (commandLength < sizeof(commandBuffer) - 1) commandBuffer[commandLength++] = c;
      else discardCommand = true;  // Jeter aussi la fin de cette ligne.
    }
  }
}

void controlSystem(unsigned long now) {
  if (!configurationOK) { trip(CONFIG); return; }
  if (floatIsOpen()) { trip(HIGH_FLOAT); return; }
  if (mode != STOPPED && !linkIsFresh(now)) { trip(LINK_LOST); return; }
  if (fault != NONE || mode == STOPPED || !sensorReady) { setPump(false); return; }
  if (pumpOn && (unsigned long)(now - pumpStartedMs) >= MAX_FILL_MS) {
    trip(FILL_TIMEOUT); return;
  }
  if (mode == AUTOMATIC) {
    if (levelPercent >= highPercent) setPump(false);
    else if (levelPercent <= lowPercent) setPump(true);
    // Entre les deux seuils : conserver la commande precedente (hysteresis).
  } else {
    if (levelPercent >= highPercent) manualRequest = false;
    setPump(manualRequest);
  }
}

void setup() {
  // Fixer le niveau de repos AVANT de configurer la sortie.
  digitalWrite(RELAY_PIN, RELAY_ACTIVE_LOW ? HIGH : LOW);
  pinMode(RELAY_PIN, OUTPUT);
  pinMode(TRIG_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);
  pinMode(HIGH_FLOAT_PIN, INPUT_PULLUP);
  digitalWrite(TRIG_PIN, LOW);
  Serial.begin(115200);
  configurationOK = isfinite(EMPTY_DISTANCE_CM) && isfinite(FULL_DISTANCE_CM)
                    && FULL_DISTANCE_CM >= 5.0f && EMPTY_DISTANCE_CM <= 350.0f
                    && EMPTY_DISTANCE_CM > FULL_DISTANCE_CM && MAX_FILL_MS > 0;
  if (!configurationOK) fault = CONFIG;
  stopSystem();
  lastSampleMs = millis() - SAMPLE_MS;
  sendStatus();
}

void loop() {
  receiveCommands();
  unsigned long now = millis();
  if (configurationOK && (unsigned long)(now - lastSampleMs) >= SAMPLE_MS) {
    lastSampleMs = now;
    sampleLevel();
  }
  now = millis();
  controlSystem(now);
  if ((unsigned long)(now - lastStatusMs) >= STATUS_MS) {
    lastStatusMs = now;
    sendStatus();
  }
}
