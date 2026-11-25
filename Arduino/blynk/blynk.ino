// Déclaration de la broche
int ledPin = 13;

void setup() {
  // Initialise la broche 13 en sortie
  pinMode(ledPin, OUTPUT);
}

void loop() {
  digitalWrite(ledPin, HIGH);  // Allume la LED
  delay(3000);                 // Attendre 1 seconde
  digitalWrite(ledPin, LOW);   // Éteint la LED
  delay(3000);                 // Attendre 1 seconde
}
