#include <Stepper.h>

const int stepsPerRevolution = 2048;

Stepper monMoteur(stepsPerRevolution, 8, 10, 9, 11);
void setup() {
  monMoteur.setSpeed(10); // vitesse en tr/min
}

void loop() {
  monMoteur.step(stepsPerRevolution);   // un tour dans un sens
  delay(1000);
  monMoteur.step(-stepsPerRevolution);  // un tour dans l’autre sens
  delay(1000);
}
