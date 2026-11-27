# Régulation de remplissage — Arduino Mega 2560 + Raspberry Pi 5

Projet de maquette avec supervision Python/Tkinter et communication série USB.
Hypothèse de matériel : **capteur HC-SR04, module relais compatible 5 V et petite
pompe 12 V continu**. Si ton capteur est un détecteur d'eau à sortie analogique,
un capteur 4–20 mA ou un autre modèle, la partie mesure doit être adaptée : les
connexions et la formule HC-SR04 ne conviennent pas directement.

## Fichiers

- `arduino/RegulationCuveMega/RegulationCuveMega.ino` : à téléverser dans la Mega.
- `supervision_cuve.py` : à exécuter sur le Raspberry Pi 5, depuis son bureau.
- `requirements.txt` : dépendance pySerial si installation dans un environnement Python.

## Fonctionnement

La Mega mesure le niveau et applique une commande **tout ou rien à hystérésis**.
Le Raspberry Pi affiche les informations et envoie les consignes. Le contrôle
de la pompe reste dans la Mega, avec une autorisation de liaison entretenue par
le programme Python.

| État ou commande | Comportement |
| --- | --- |
| Mise sous tension ou connexion USB | Mode STOP, relais au repos |
| Mode AUTO, niveau ≤ seuil bas (20 % par défaut) | Commande de remplissage |
| Mode AUTO, niveau entre les deux seuils | Conserver l'état précédent du relais |
| Mode AUTO, niveau ≥ seuil haut (90 % par défaut) | Arrêter le remplissage |
| Mode MANUEL | Attendre un clic sur Marche pompe |
| Mode MANUEL, seuil haut atteint | Arrêter la pompe et annuler la demande de marche |
| ARRÊT DU SYSTÈME | Arrêter la pompe et revenir en STOP |
| Réarmer | Effacer le défaut si les conditions sont bonnes ; rester en STOP |
| Changement de mode | Arrêter la pompe avant d'appliquer le nouveau mode |

Après un démarrage en AUTO avec un niveau entre les seuils, la pompe reste
arrêtée jusqu'à atteindre le seuil bas. En MANUEL, le seuil haut reste actif.
Les seuils réglés dans Tkinter sont conservés en RAM uniquement : après un
redémarrage de la Mega, ils reviennent à 20 % / 90 %.

## Câblage de la maquette

Couper l'alimentation de la pompe pendant le câblage et le téléversement.

| Élément | Connexion Arduino Mega |
| --- | --- |
| HC-SR04 VCC | 5 V |
| HC-SR04 GND | GND |
| HC-SR04 TRIG | D22 |
| HC-SR04 ECHO | D23 |
| Module relais IN | D24 |
| Module relais VCC / GND | Selon sa notice ; pour un module 5 V simple : 5 V / GND |
| Flotteur haut optionnel, contact fermé au repos | D26 ↔ contact ↔ GND |
| Raspberry Pi 5 ↔ Mega | Câble USB de données ; prise USB-B côté Mega |

Le HC-SR04 est branché uniquement à la Mega. Aucun GPIO du Raspberry Pi n'est
utilisé. Installer le capteur au-dessus de l'eau, face à la surface et à l'abri
des projections ; le HC-SR04 standard n'est pas étanche. Les parois, la mousse
et les turbulences peuvent fausser la mesure : vérifier les distances sur la
maquette avant d'autoriser la pompe.

Pour une pompe 12 V : utiliser une alimentation extérieure adaptée et les
contacts COM/NO du relais. Le circuit de puissance est : alimentation +12 V →
fusible adapté → COM, puis NO → pompe + ; pompe − → alimentation 0 V. La pompe
ne se branche jamais directement sur une broche de la Mega ou du Pi. Choisir
un relais capable de commuter le courant de démarrage du moteur et une
protection adaptée à la charge inductive.

Le réglage par défaut suppose un relais actif à LOW. Une résistance de rappel
de 10 kΩ entre IN et 5 V aide à maintenir le relais au repos pendant un reset
de la Mega ; vérifier que le module accepte ce montage. Pour un relais actif à
HIGH, modifier `RELAY_ACTIVE_LOW` et utiliser le rappel adapté vers GND.
Valider le repos du relais à la mise sous tension avant d'alimenter la pompe.

Pour un montage réel, prévoir une coupure matérielle de niveau haut indépendante
du logiciel et une coupure manuelle de la pompe. La lecture optionnelle de D26
complète cette protection ; elle ne remplace pas une coupure indépendante.
Cette maquette ne comporte ni retour de marche, ni mesure de débit, ni détection
de manque d'eau à l'aspiration. L'affichage « relais pompe » indique la commande,
pas la preuve que la pompe tourne ou que l'eau circule. Ce projet ne constitue
pas une chaîne de sécurité industrielle validée.

## Calibration à modifier dans le programme Arduino

```cpp
const bool RELAY_ACTIVE_LOW = true;
const bool USE_HIGH_FLOAT = false;
const float EMPTY_DISTANCE_CM = 120.0f;
const float FULL_DISTANCE_CM = 20.0f;
const unsigned long MAX_FILL_MS = 120000UL;
```

1. Mesurer la distance entre la face du capteur et le fond, cuve vide : c'est
   `EMPTY_DISTANCE_CM`.
2. Mesurer la distance entre la face du capteur et la surface au niveau utile
   maximal : c'est `FULL_DISTANCE_CM`. Conserver au moins 5 cm dans ce programme.
3. Vérifier que la distance à vide est supérieure à la distance à plein et ne
   dépasse pas 350 cm dans cette version.
4. Adapter `MAX_FILL_MS` au temps de remplissage normal avec une marge raisonnable.
   La valeur de 120 000 ms correspond à 2 minutes pour une petite maquette.
5. Si un flotteur est installé, mettre `USE_HIGH_FLOAT = true` et vérifier que
   son contact est fermé vers GND en situation normale, ouvert au niveau haut.
   Un fil coupé entraîne alors aussi l'arrêt.

Calcul appliqué :

```text
niveau (%) = 100 × (distance à vide − distance mesurée)
                   / (distance à vide − distance à plein)
```

Le résultat est limité entre 0 et 100 %. Exemple : distances vide/plein de
120/20 cm ; une mesure de 70 cm correspond à 50 %. Il s'agit du pourcentage de
hauteur utile. Le pourcentage de volume est identique uniquement pour une cuve
de section constante sur cette hauteur.

## Installation Arduino

1. Dans Arduino IDE, installer le support **Arduino AVR Boards** si nécessaire.
2. Ouvrir `RegulationCuveMega.ino` dans son dossier `RegulationCuveMega`.
3. Choisir la carte **Arduino Mega or Mega 2560**, processeur ATmega2560, et le
   port de la carte.
4. Adapter les paramètres puis téléverser, pompe non alimentée.
5. Fermer le moniteur série avant de connecter la supervision : un seul programme
   doit utiliser le port USB.

Aucune bibliothèque Arduino additionnelle n'est nécessaire.

## Installation Raspberry Pi 5

Sur Raspberry Pi OS avec un bureau graphique, ouvrir un terminal :

```bash
sudo apt update
sudo apt install python3-tk python3-serial
```

Décompresser le projet puis ouvrir un terminal dans le dossier qui contient
`supervision_cuve.py` et lancer :

```bash
python3 supervision_cuve.py
```

Autre méthode pour pySerial, si tu utilises déjà un environnement virtuel :

```bash
python3 -m pip install -r requirements.txt
```

Ne pas utiliser `sudo pip` ni forcer l'installation dans le Python système.
Pour tester Tkinter seul :

```bash
python3 -m tkinter
```

Une session SSH sans affichage graphique ne peut pas ouvrir cette fenêtre.
Lancer depuis le bureau local ou une session de bureau à distance du Pi.

## Première utilisation

1. Laisser la pompe hors tension ; vérifier le câblage et la calibration.
2. Brancher la Mega en USB au Pi et lancer le programme Python.
3. Cliquer sur **Actualiser**, choisir `/dev/ttyACM0`, `/dev/ttyUSB0` ou le port
   effectivement détecté, puis **Connecter**. Un chemin `/dev/serial/by-id/...`
   peut aussi être saisi pour désigner une carte de manière plus stable.
4. Attendre environ 2 secondes de démarrage puis 3 mesures valides. Le niveau
   et la distance doivent correspondre à tes mesures physiques.
5. En mode STOP, régler les seuils, puis cliquer sur **Appliquer**. Les valeurs
   confirmées apparaissent sous la cuve dans « Seuils Arduino ».
6. Simuler les différents niveaux avec une surface plane pour vérifier le
   capteur et le relais, puis tester le bouton ARRÊT et les défauts ci-dessous.
7. Après validation, faire un essai avec la petite pompe 12 V, sous surveillance.
   Cliquer sur **Mode automatique** pour lancer la régulation.

Les commandes sont confirmées par les états reçus de la Mega. L'IHM ne suppose
pas que le relais a changé d'état simplement parce qu'un bouton a été cliqué.

## Arrêts sur défaut et essais

| Essai | Résultat attendu |
| --- | --- |
| Capteur sans écho ou mesure hors plage en fonctionnement | Arrêt à la prochaine mesure (période 300 ms, attente écho limitée à 25 ms), défaut SENSOR mémorisé |
| Arrêt brutal du programme Python ou absence de PING | Arrêt et défaut LINK_LOST après 5 s sans PING si la Mega reste alimentée |
| Fenêtre Python bloquée | Les PING dépendent de la boucle Tk ; leur émission cesse et la Mega finit par arrêter |
| Absence de télémétrie côté Python pendant plus de 2,5 s | Valeurs déclarées inconnues, STOP demandé, interruption des PING |
| Fermeture normale ou bouton Déconnecter | Tentative d'envoi STOP avant fermeture du port ; délai de liaison comme secours |
| Remplissage continu plus long que MAX_FILL_MS | Arrêt et défaut FILL_TIMEOUT mémorisé |
| Flotteur haut ouvert, option activée | Arrêt et défaut HIGH_FLOAT mémorisé |
| Retour du capteur ou de la liaison après un défaut | Aucun redémarrage automatique ; corriger, Réarmer, puis sélectionner le mode |
| Débranchement puis rebranchement USB | Reconnexion manuelle, démarrage en STOP |

Le bouton de réarmement reste sans effet tant que le capteur n'a pas fourni
3 mesures valides, que le flotteur reste ouvert, que la calibration est
incorrecte ou que les PING ne sont pas reçus. ARRÊT ne supprime pas les défauts.

Pour un test de perte de liaison en gardant la Mega alimentée, arrêter le
processus Python ou interrompre les PING ; débrancher le seul câble qui alimente
la Mega coupe également son alimentation et teste un autre cas.

## Dépannage

- **Aucun port** : vérifier que le câble USB transporte les données, puis
  actualiser. La carte peut apparaître comme ttyACM ou ttyUSB selon son interface.
- **Permission denied** : vérifier l'appartenance au groupe `dialout`. Si besoin :
  `sudo usermod -aG dialout "$USER"`, puis fermer complètement la session et se
  reconnecter avant de relancer Python. Ne pas utiliser `chmod 777` sur le port.
- **Port occupé** : fermer le moniteur série Arduino et les autres programmes
  utilisant cette carte.
- **Relais inversé** : contrôler `RELAY_ACTIVE_LOW` avec la pompe hors tension.
- **Niveau incohérent** : vérifier les distances de calibration, l'orientation du
  capteur, les échos sur les parois et les unités en centimètres.
- **FILL_TIMEOUT** : vérifier le débit, l'alimentation, les tuyaux et la source
  d'eau avant d'adapter le temps maximal.

## Protocole USB pour comprendre ou adapter

115200 bauds, 8 bits, sans parité, 1 bit de stop. Une commande ASCII par ligne.
Le récepteur conserve les fragments jusqu'au retour à la ligne. Les lignes
excessivement longues sont rejetées en entier.

| Commande | Effet |
| --- | --- |
| `PING` | Entretenir l'autorisation de liaison, une fois par seconde |
| `STATUS` | Demander un état immédiat |
| `STOP` | Arrêter le système |
| `AUTO` | Sélectionner la régulation automatique |
| `MANUAL` | Sélectionner le mode manuel, pompe arrêtée |
| `ON` / `OFF` | Commander la pompe en mode manuel |
| `RESET` | Réarmer sous conditions, rester en STOP |
| `SET 20 90` | Changer les seuils en STOP ; entiers 1–95, écart minimal 3 |

La Mega transmet un état JSON toutes les 500 ms et après une commande reconnue.
`pump` correspond à la commande relais ; `valid=0` rend les mesures indisponibles.

```json
{"type":"status","ms":12345,"mode":"AUTO","pump":1,"valid":1,"level":35.0,"distance_cm":85.0,"low":20,"high":90,"alarm":"NONE"}
```

Les lignes `ACK ...` confirment l'acceptation d'une commande ; `ERR ...` signalent
un refus. Un ACK ne remplace pas la télémétrie pour connaître l'état du relais.

## Documentation officielle

- [Arduino Mega 2560](https://docs.arduino.cc/hardware/mega-2560)
- [API pySerial et délais de lecture/écriture](https://pyserial.readthedocs.io/en/latest/pyserial_api.html)
- [Tkinter et boucle d'événements](https://docs.python.org/3/library/tkinter.html)

## Portée de la validation

Vérifications effectuées : syntaxe Python, 93 assertions sur la logique du
sketch en simulation C++ (configuration normale, flotteur activé et calibration
invalide), et 11 tests Python incluant une liaison série virtuelle par
pseudo-terminal. Les trames JSON émises par le sketch simulé ont aussi été lues
par le parseur Python. La vérification des appels confirme que le thread série
ne modifie pas les widgets Tk.

Ces vérifications ne remplacent pas la compilation avec le
support AVR dans Arduino IDE, l'ouverture de Tkinter sur le Raspberry Pi et les
essais de la pompe et des protections sur le montage réel.
