#include<stdio.h>

void main(void)
{
    const int c1=1, c2=2; // Variables internes
    int n1, n2, n3;
    float moy;

    printf("EXERCICE 10:\n\n");
    printf("Saisissez vos 3 notes SVP : \n");
    scanf("%d",&n1);scanf("%d",&n2);scanf("%d",&n3); // Saisie des notes

    // Affichage des notes
    printf("Releve de Notes : \n");
    printf("Note 1 : %d/20 \n",n1);
    printf("Note 2 : %d/20 \n",n2);
    printf("Note 3 : %d/20 \n",n3);


    printf("\n Moyenne =%.2f20\n",(float)((n1+n2)*c1+n3*c2)/(2*c1+c2)); // Affichage de la moyenne

    moy=(float)((n1+n2)*c1+n3*c2)/(2*c1+c2);
    if(moy<10)
    {
        printf("REFUSE(E) \n");
    }
    else
    {
        printf("Admis(e) \n");
    }
}
