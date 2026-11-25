#include<stdio.h>

void main(void)
{
    int nb;
    printf("EXERCICE 11\n");
    printf("Un numero de jour : ");
    scanf("%d",&nb);

    switch(nb)
    {
        case 1: printf("Lundi \n"); break;
        case 2: printf("Mardi \n"); break;
        case 3: printf("mercredi \n"); break;
        case 4: printf("Jeudi \n"); break;
        case 5: printf("Vendredi \n"); break;
        case 6: printf("Samedi \n"); break;
        case 7: printf("Dimanche \n\n"); break;
        default : printf("Revoir votre valeur \n");
    }
}
