// C++ code
//

int BP_MARCHE = 2; // Declarer bouton pousoir allumer L1 et le moteur
int BP_ARRET = 3; /* Declarer bouton pousoir Etteindre le moteur 
et L1 et allumer L2 */
int BP_STOP = 4; // Arret du système

int lampe1 = 5; // Déclarer L1
int lampe2 = 6; // Déclarer L2

int etatBouton_MARCHE = 0; /* Déclarer la variable pour l'appuie 
sur BP_MARCHE */
int etatBouton_ARRET = 0; /* Déclarer la variable pour l'appuie 
sur BP_ARRET */
int etatBouton_STOP = 0; /* Déclarer la variable pour l'appuie 
sur BP_STOP */

void setup()
{
  pinMode(BP_MARCHE, OUTPUT); // Initialiser pin2
  pinMode(BP_ARRET, OUTPUT); // Initialiser pin3
  pinMode(BP_STOP, OUTPUT); // Initialiser pin4
  pinMode(lampe1, OUTPUT); // Initialiser pin5
  pinMode(lampe2, OUTPUT); // Initialiser pin6
}

void loop()
{
  etatBouton_MARCHE = digitalRead(BP_MARCHE);/* Condition
  d'activation de L1 et le moteur*/
  etatBouton_ARRET = digitalRead(BP_ARRET);/* Condition
  d'activation de L2 et extinction de L1 et le moteur*/
  etatBouton_STOP = digitalRead(BP_STOP);/* Condition
  d'arret general*/
  if(etatBouton_MARCHE == HIGH){
    digitalWrite(lampe1, HIGH);
    digitalWrite(lampe2,LOW);
  } else if (etatBouton_ARRET == HIGH){
    digitalWrite(lampe1, LOW);
    digitalWrite(lampe2, HIGH);
  }
  else if (etatBouton_STOP == HIGH){
    digitalWrite(lampe1, LOW);
    digitalWrite(lampe2, LOW);
  }
}


 


