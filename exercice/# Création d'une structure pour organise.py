# Création d'une structure pour organiser les réponses aux questions du problème de malaxage
from docx import Document

doc = Document()

doc.add_heading("Correction complète – Problème : Malaxage des produits A et B", 0)

# Question 1
doc.add_heading("1. Circuit de puissance", level=1)
doc.add_paragraph(
    "Le circuit de puissance doit intégrer :\n"
    "- Le moteur MR en démarrage étoile-triangle (Y-Δ), avec contacteurs K1 (étoile), K2 (triangle), et K3 (ligne).\n"
    "- Les moteurs MP et MT en démarrage direct, chacun avec un contacteur et protection thermique (ex : K4 pour MP, K5 pour MT).\n"
    "- Une alimentation triphasée pour tous les moteurs, protégée par disjoncteur moteur.\n"
    "- Un sectionneur général en tête, suivi d’un relais thermique pour chaque moteur."
)

# Question 2
doc.add_heading("2. Inventaire des équipements", level=1)
doc.add_paragraph("Actionneurs et pré-actionneurs :")
doc.add_paragraph(
    "- VA, VB, VC : électrovannes NF bistables\n"
    "- MR : moteur de malaxage (Y-Δ)\n"
    "- MP : moteur de pivotement (direct)\n"
    "- MT : moteur du convoyeur (direct)\n"
    "- K1 à K5 : contacteurs\n"
    "- H1 : voyant présence tension\n"
    "- Voyants défauts thermiques pour chaque moteur"
)

doc.add_paragraph("Capteurs et poussoirs :")
doc.add_paragraph(
    "- S0, S1 : capteurs de position cuve\n"
    "- S10 : poussoir départ AUTO\n"
    "- S11 : poussoir test MANU\n"
    "- SAU : arrêt d’urgence\n"
    "- d : détecteur de passage (convoyeur)\n"
    "- Capteur de position de la bascule : z, a, b"
)

# Question 3
doc.add_heading("3. GRAFCET de conduite GC (commande)", level=1)
doc.add_paragraph(
    "Étapes principales :\n"
    "0 : Attente de S10\n"
    "1 : Lancement AUTO (activation GCT)\n"
    "2 : Mode MANU activé par S11 (test moteurs MT, MP, MR un à un)\n"
    "Transitions en fonction de S10, S11, et présence tension (H1)\n"
    "Gestion de priorité entre MANU et AUTO\n"
    "Fin si SAU activé (réinitialisation)."
)

# Question 4
doc.add_heading("4. GRAFCET de coordination des tâches (GCT)", level=1)
doc.add_paragraph(
    "Structure séquentielle :\n"
    "Étape 0 : Attente de S10\n"
    "1 : Ouverture VA, arrêt sur a\n"
    "2 : Ouverture VB, arrêt sur b\n"
    "3 : Ouverture VC (versement dans cuve)\n"
    "4 : Activation MT (5s de convoyage)\n"
    "5 : Activation MR (15s de malaxage)\n"
    "6 : Activation MP pour basculement vers S1\n"
    "7 : Pause 5s puis retour S0\n"
    "8 : Retour à étape 0 si matières disponibles"
)

# Question 5
doc.add_heading("5. GRAFCETs des tâches (GT1 à GTn)", level=1)
doc.add_paragraph(
    "GT1 : Dosage VA → ouvrir VA, attendre a, fermer VA\n"
    "GT2 : Dosage VB → ouvrir VB, attendre b, fermer VB\n"
    "GT3 : Versement → ouvrir VC, attendre fin, fermer VC\n"
    "GT4 : Convoyage → démarrer MT, temporiser 5s, arrêter MT\n"
    "GT5 : Malaxage → démarrer MR, temporiser 15s, arrêt\n"
    "GT6 : Basculement → MP vers S1, pause 5s, retour S0"
)

# Question 6
doc.add_heading("6. GRAFCET de sûreté (GS)", level=1)
doc.add_paragraph(
    "Étape 0 : Surveillance continue\n"
    "Transition : Si SAU appuyé, activer étape d’arrêt\n"
    "1 : Désactivation de tous les actionneurs\n"
    "2 : Réinitialisation du système (étape vide)\n"
    "Voyants défauts s’activent si relais thermiques déclenchés"
)

# Question 7
doc.add_heading("7. Schéma des modules d’entrées/sorties API", level=1)
doc.add_paragraph("Entrées API :")
doc.add_paragraph(
    "- E0.0 : S10 (AUTO)\n"
    "- E0.1 : S11 (MANU)\n"
    "- E0.2 : SAU\n"
    "- E0.3 : Capteur a\n"
    "- E0.4 : Capteur b\n"
    "- E0.5 : Capteur z\n"
    "- E0.6 : S0 (cuve)\n"
    "- E0.7 : S1 (cuve)\n"
    "- E1.0 : d (détecteur passage)\n"
    "- E1.1 à E1.3 : défauts moteurs"
)

doc.add_paragraph("Sorties API :")
doc.add_paragraph(
    "- Q0.0 : VA\n"
    "- Q0.1 : VB\n"
    "- Q0.2 : VC\n"
    "- Q0.3 : MT\n"
    "- Q0.4 : MR (via séquence étoile-triangle)\n"
    "- Q0.5 : MP\n"
    "- Q0.6 : Voyant H1\n"
    "- Q0.7 à Q1.1 : Voyants défaut moteurs"
)

# Enregistrement du document
output_path = "/mnt/data/Correction_Malaxage_ARSI6.docx"
doc.save(output_path)
output_path
