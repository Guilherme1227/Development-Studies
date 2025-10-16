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
    int numb;
    
    cout<<"Digite um numero: "<<endl;
    cin>>numb;
    
    if(numb%2 == 0){
        cout<<"O numero "<<numb<<" é par."<<endl;
    }else{
        cout<<"O numero "<<numb<<" é impar."<<endl;
    }

    return 0;
}