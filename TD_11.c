#include<stdio.h>

char rep; // Variable ext
void main(void)
{
    const float Pi=3.14; // Variables internes
    float r,pe,ai;

    printf("EXERCICE 7: \n\n");

    do
    {
        printf("Valeur du rayon : "); // Saisie données
        scanf("%f",&r);
        printf("\n");

        // Calcul de l'air et du perimetre
        printf("Perimetre = %f m\n", 2*r*Pi); //Calcul & Affichage
        printf("\n");

        // operation de c
        printf("Aire = %f m2\n",r*r*Pi);
        printf("\n");

        printf("Voulez-vous Recommencer (o/n)? :");
        scanf(" %c",&rep);
    }while(rep=='o');

}
