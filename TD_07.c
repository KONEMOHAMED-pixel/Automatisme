#include<stdio.h>

char nm[20];

void main (void)
{
    printf("EXERCICE n2 \n");
    printf("\n");

    // Saisie des données
    printf("Saisir un nom : ");
    scanf("%s",&nm);

    // Affichage message
    printf("%s, Bienvenu(e) au CME.",nm);
}
