#include<stdio.h>

const int ana=2025;
int ag,ann;

void main (void)
{
    printf("EXERCICE n5\n");
    printf("\n");

    // Saisie des données
    printf("Une annee de Naissance SVP : ");
    scanf("%d",&ann);

    ag = ana-ann; // Operation Calcul

    // Affichage
    printf("age=%d an(s)\n\n",ag);

    // Condition : status de l'individu
    if(ag<=1)
    {
        printf("Un nouveau nee\n");

    }
}
