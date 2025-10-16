/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <iostream>
using namespace std;
int main()
{ 
    int numb, mult;
    
    cout<<"Digite um numero: "<<endl;
    cin>>numb;
    cout<<"Digite outro numero: "<<endl;
    cin>>mult;
    
    if(numb%mult == 0){
        cout<<"O numero "<<numb<<" é multiplo de "<<mult<<endl;
    }else{
        cout<<"O numero "<<numb<<" não é multiplo de "<<mult<<endl;
    }

    return 0;
}