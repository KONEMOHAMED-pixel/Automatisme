#include<stdio.h>

const int ana=2025;
int ag, ann;

void main (void)
{
    printf("EXERCICE n5\n");
    printf("\n");

    // Saisie des données
    printf("Une annee de Naissance SVP : ");
    scanf("%d",&ann);

    ag = ana-ann; // Operation Calcul

    // Affichage
    printf("Age = %d an(s)",ag);
}
