#include<iostream>

using namespace std;

main(void)
{
    int rep;
    const int c1=1, c2=2;
    int n1, n2, n3;
    float moy;

    cout << "CALCUL DE MOYENNE \n"; rep=1;
    while(rep==1){
    cout << "Saisir vos Notes :" <<endl;

    cout<<"Note 1 :"; cin >>n1;
    cout<<"Note 2 :"; cin >>n2;
    cout<<"Note 3 :"; cin >>n3;

    moy=(float)((n1+n2)*c1+n3*c2)/(2*c1+c2);
    cout << "Moyenne =" << moy << "/20" << endl;
    if(moy<10) cout<<"ECHEC"; else cout<<"Admis(e)";
    cout <<"Voulez-vous recommencer(1/2)? :";
    cin >>rep;
    }
}
