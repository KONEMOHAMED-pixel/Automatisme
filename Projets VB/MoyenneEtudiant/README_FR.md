# Calcul de la moyenne d'un étudiant

Application VB.NET Windows Forms pour trois notes sur 20 de même coefficient.

## 1. Algorithme

Lire d'abord le fichier **ALGORITHME.txt**. Il présente les variables, la saisie,
le calcul de moyenne et les conditions qui déterminent l'appréciation.

La formule est : `moyenne = (note1 + note2 + note3) / 3`.
La moyenne est arrondie à deux décimales avant de déterminer l'appréciation.

## 2. Barème choisi

| Moyenne arrondie M | Appréciation |
| --- | --- |
| 0 ≤ M < 8 | Très insuffisant |
| 8 ≤ M < 10 | Insuffisant |
| 10 ≤ M < 12 | Passable |
| 12 ≤ M < 14 | Assez bien |
| 14 ≤ M < 16 | Bien |
| 16 ≤ M ≤ 20 | Très bien |

## 3. Ouvrir le projet fourni

1. Extraire tout le dossier de l'archive ZIP.
2. Sous Windows, ouvrir **MoyenneEtudiant.vbproj** dans Visual Studio.
3. Le projet cible **.NET Framework 4.8**. Le composant Visual Studio
   **Développement Desktop .NET** et le pack de ciblage .NET Framework 4.8
   sont nécessaires à la compilation. Si Visual Studio les réclame, les ajouter
   avec Visual Studio Installer.
4. Appuyer sur **F5** pour compiler et lancer l'application.
5. Saisir les trois notes, puis cliquer sur **Calculer**.

Le formulaire est déjà créé et peut être ouvert dans le concepteur de Visual
Studio. Les champs sont initialisés à 0, qui est une note valide.
Les résultats sont effacés quand une note change : cliquer de nouveau sur
**Calculer** pour les actualiser.

Le projet contient les sources ; aucun exécutable compilé n'est inclus.
La structure du projet a été vérifiée. La compilation et l'interface graphique
n'ont pas pu être exécutées dans l'environnement de préparation.

## 4. Recréer le formulaire pour s'exercer

Créer un projet **Application Windows Forms (.NET Framework)** en **Visual Basic**.
Dans le formulaire Form1, ajouter les contrôles suivants avec les noms exacts :

| Contrôle | Propriété (Name) | Texte ou rôle |
| --- | --- | --- |
| NumericUpDown | nudNote1 | Première note |
| NumericUpDown | nudNote2 | Deuxième note |
| NumericUpDown | nudNote3 | Troisième note |
| Button | btnCalculer | Calculer |
| Label | lblMoyenne | Moyenne : — |
| Label | lblAppreciation | Appréciation : — |

Ajouter aussi trois labels statiques portant les textes **Note 1**, **Note 2**,
et **Note 3** à côté des champs.
Pour chaque NumericUpDown, régler **Minimum = 0**, **Maximum = 20**,
**DecimalPlaces = 2**, **Increment = 0,5** et **Value = 0**.
La valeur numérique se lit avec la propriété **Value**.

Copier le contenu de **Form1.vb** dans le fichier de code Form1.vb du nouveau
projet, en remplaçant la classe Form1 existante. Conserver le fichier Designer
généré par Visual Studio : il contient les contrôles ajoutés manuellement.

## 5. Fichiers du projet

- **ALGORITHME.txt** : algorithme en français.
- **Form1.vb** : calcul et appréciation au clic sur le bouton.
- **Form1.Designer.vb** : disposition et propriétés des contrôles.
- **Program.vb** : démarrage de l'application.
- **MoyenneEtudiant.vbproj** : projet Visual Studio.
- **App.config** : version du framework utilisée.

## 6. Exemples à essayer

| Note 1 | Note 2 | Note 3 | Moyenne affichée | Appréciation attendue |
| --- | --- | --- | --- | --- |
| 12 | 14 | 16 | 14,00 | Bien |
| 8 | 10 | 12 | 10,00 | Passable |
| 6 | 7 | 8 | 7,00 | Très insuffisant |
| 20 | 20 | 20 | 20,00 | Très bien |
| 0 | 0 | 0 | 0,00 | Très insuffisant |
| 9,99 | 10 | 10 | 10,00 | Passable |

## Références

- [NumericUpDown : saisie numérique Windows Forms](https://learn.microsoft.com/fr-fr/dotnet/desktop/winforms/controls/numericupdown-control-windows-forms)
- [Exécuter du code au clic sur un bouton](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-respond-to-windows-forms-button-clicks)
