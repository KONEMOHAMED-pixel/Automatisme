#include<stdio.h>

void main(void)
{
    int a,b,c,TEMP; // Variables int
    printf("EXERCICE 6\n\n");

    printf("Saisir 3 entiers SVP : "); // Saisie data
    scanf("%d",&a);
    scanf("%d",&b);
    scanf("%d",&c);

    printf("Affichage de Donnees : \n"); // Affichage 1
    printf("Entier 1 : %d , Entier 2 : %d , Entier 3 : %d \n\n",a,b,c);

    TEMP = a; // Operateur d'Affectation
       a = b;
       b = TEMP;

    // Affichage Contenu permuté
    printf("Nouvel Affichage :\n");
    printf("Entier 1 : %d , Entier 2 : %d , Entier 3 : %d \n\n",a,b,c);
}
