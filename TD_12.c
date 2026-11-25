#include<stdio.h>

void main (void)
{
    const float tva=0.18; // Variables internes
    int px,qt;

    printf("EXERCICE 8 :\n\n");
    printf("Quantite :");scanf("%d",&qt);
    printf("Prix Unitaire HT :");scanf("%d",&px);

    printf("Montant HT = %f Fcfa",(float)qt*px);
    printf("Montant TTC = %f Fcfa",(float)qt*px+(1+tva));
}
