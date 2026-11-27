# Régulation du remplissage d'une cuve d'eau — VB.NET / Windows Forms

Ce projet est une simulation pédagogique. Il affiche le niveau d'eau et l'état
de la pompe. Il ne communique avec aucun capteur, relais, Arduino ou automate.

## Ouvrir et lancer

1. Sur un PC Windows, installer Visual Studio 2026 avec la charge de travail
   « Développement Desktop .NET » et le composant .NET 10.
2. Extraire entièrement l'archive ZIP.
3. Ouvrir `RegulationCuve.vbproj` dans Visual Studio.
4. Appuyer sur F5, puis cliquer sur « Démarrer » dans la fenêtre.

La fenêtre et ses composants sont déjà créés. Aucun contrôle n'est à ajouter.
Le concepteur visuel de Visual Studio permet de modifier la fenêtre.

Windows Forms nécessite Windows : cette interface ne s'exécute pas nativement
sous Raspberry Pi OS. Visual Studio et Visual Studio Code sont deux logiciels
distincts ; la procédure ci-dessus utilise Visual Studio sur Windows.

## Fonctionnement

| Situation | Commande de la pompe |
| --- | --- |
| Régulation arrêtée | Arrêt |
| Niveau inférieur ou égal au seuil bas (20 % par défaut) | Marche |
| Niveau supérieur ou égal au seuil haut (90 % par défaut) | Arrêt |
| Niveau entre les deux seuils | Conservation de l'état précédent |

Cette régulation s'appelle « tout ou rien avec hystérésis ». Elle utilise une
pompe en marche/arrêt, sans calcul PID et sans variation de vitesse.

Le niveau initial est 10 %. À chaque événement du Timer (intervalle nominal
d'une seconde), la simulation ajoute 5 points de niveau si la pompe tourne et
retire 1 point si « Simuler une consommation d'eau » est cochée. Avec les deux
actions, la hausse est donc de 4 points par pas. Le niveau est borné entre 0 et
100 %. Ces valeurs servent à observer les cycles et ne sont pas des débits réels.
Le Timer de l'interface n'est pas une horloge temps réel.

- **Démarrer** active la régulation et lance la simulation. La commande est
  calculée immédiatement avec le niveau actuel.
- **Arrêter** coupe la commande de la pompe et fige la simulation, y compris
  la consommation.
- **Réinitialiser à 10 %** arrête la régulation puis remet le niveau à 10 %.
  Les seuils réglés et le choix de consommation sont conservés.
- Les seuils sont modifiables à l'arrêt. Le seuil bas doit être strictement
  inférieur au seuil haut.
- Décocher la consommation permet d'observer un remplissage suivi d'un arrêt
  stable au seuil haut, tant que la régulation reste active.

Un arrêt remet la commande de pompe à l'état arrêt. Si on redémarre avec un
niveau entre les seuils, elle reste donc arrêtée jusqu'au seuil bas. Avec des
seuils personnalisés, un pas de simulation peut légèrement dépasser le seuil
haut ; la commande est coupée dès que la nouvelle mesure atteint ou dépasse
ce seuil.

## Exemple de cycle avec les réglages par défaut

1. Démarrage à 10 % : la pompe se met en marche.
2. Le niveau augmente de 4 points par pas avec la consommation cochée.
3. À 90 %, la pompe s'arrête.
4. La consommation fait descendre le niveau d'un point par pas.
5. À 20 %, la pompe redémarre. Le cycle se répète.

## Organisation du code

| Fichier | Rôle |
| --- | --- |
| `Form1.vb` | Boutons, simulation, mise à jour de l'affichage |
| `Form1.Designer.vb` | Création et position des composants de la fenêtre |
| `Regulation.vb` | Décision de marche/arrêt avec mémoire entre les seuils |
| `Program.vb` | Point d'entrée de l'application |
| `RegulationCuve.vbproj` | Configuration du projet .NET 10 pour Windows |

Pour étudier le programme, commencer par `Regulation.vb`, puis suivre les
événements des boutons et `Timer1_Tick` dans `Form1.vb`.

## Adaptation à une vraie cuve

Il faudra remplacer le calcul du niveau simulé par la lecture du capteur, puis
transmettre la commande de pompe à une interface matérielle adaptée. Le choix
dépendra du capteur, de la pompe et de l'Arduino ou de l'automate utilisés.
L'arrêt de sécurité et la protection contre le débordement devront fonctionner
indépendamment de la fenêtre Windows.

## Compilation en ligne de commande

Avec le SDK .NET 10 installé, depuis le dossier du projet :

```powershell
dotnet build RegulationCuve.vbproj -c Release
dotnet run --project RegulationCuve.vbproj
```

La commande de lancement nécessite Windows.

## Vérifications effectuées

La compilation du projet ciblant Windows a réussi avec le SDK .NET 10.0.100,
sans erreur ni avertissement. Vingt vérifications exécutées sur la fonction
`CommanderPompe` ont validé les seuils inclusifs, la mémoire entre les seuils,
la priorité de l'arrêt, le rejet des valeurs invalides et un cycle complet
avec les réglages par défaut.

La fenêtre n'a pas été exécutée dans l'environnement Linux de préparation.
Son affichage et ses interactions restent à vérifier sur un PC Windows.

## Documentation Microsoft

- Création d'une application Windows Forms :
  https://learn.microsoft.com/dotnet/desktop/winforms/get-started/create-app-visual-studio
- Timer Windows Forms :
  https://learn.microsoft.com/dotnet/desktop/winforms/controls/timer-component-overview-windows-forms
- Compatibilité Windows :
  https://learn.microsoft.com/dotnet/desktop/winforms/migration/
