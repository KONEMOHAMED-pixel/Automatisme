#include<stdio.h>

void main(void)
{
    int i,n; // Variables internes

    printf("EXERCICE 12 ");
    printf("liste des 10ers entiers \n");

    // Afficher les 10ers entiers naturels
    for(i=0;i<=9;i++)
    {
        printf("Valeur = %d \n",i);
    }

    // Affichage sur une ligne
    printf("Affichage sur 1 ligne \n");
    for(i=0;i<=9;i++) printf("%d\t",i);

    // Afficher la somme des 10 premiers entiers après le nombre
    printf("\n\nEXERCICE 13 : \n");
    printf("Un entier SVP : ");
    scanf("%d",&n); // Saisie des valeurs

    int som; // Variable pour afficher la somme des 10 premiers entiers apres le nombre
    som=0;

    for(i=1;i<=10;i++)
    {
        som=som+(n+1);
    }
    printf("Total = %d\n",som);
}
