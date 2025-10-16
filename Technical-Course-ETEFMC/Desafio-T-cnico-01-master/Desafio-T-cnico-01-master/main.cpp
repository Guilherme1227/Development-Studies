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
    int Nowfollows, Futurefollows, Senha;
    bool Verificar = false, Robotest = true;
    char Reafirmar, Confirmar, Antibot;
    float Margemdecrescimento;
    double Saldo;
    
    string Nomedeusuario, SobreMim;
    
    
    cout<<"Bem vindo ao registro de SocialJujutsu, comece inserindo seu nome de feiticeiro"<<endl;
    
    cin >> Nomedeusuario;
    
    cout<<"Tem certeza do nome? Escreva S para confirmar"<<endl;
    cin >> Confirmar;
    
    if (Confirmar == 'S'){
        cout<<"Obrigado por confimar!"<<endl; 
    } 
    else {
        cout << "Para substituir o nome, reinicie o programa.";
    }
    cout<<"Crie uma senha que contenha apenas numeros:"<<endl;
    
    cin >> Senha;
    
    cout<<"Tem certeza da senha? Escreva S para confirmar"<<endl;
    cin >> Confirmar;
    
    if (Confirmar == 'S'){
        cout<<"Obrigado por confimar!"<<endl; 
    } 
    else {
        cout << "Para substituir a senha, reinicie o programa.";
    }
    
    cout << "Verifique as informações anteriores as reescrevendo V abaixo:"<<endl;
 
    cin >> Reafirmar;
    if ( Reafirmar == 'V'){
        Verificar = true;
    } else {
        Robotest = false;
        cout << "Corfirme não ser um robo digitando:"<<endl;
        cout << "N"<<endl;
        cin >> Antibot;
        if ( Antibot == 'N'){
            Robotest = true;
        }
    }
    
    cout << "Quantos seguidores tem em outras redes?"<<endl;
    cin >> Nowfollows;
    cout << "Quantos seguidores pretende alcançar?"<<endl;
    cin >> Futurefollows;
    
    cout << "Para completar o registro escreve uma palavra sobre você:"<<endl;
    cin >> SobreMim;
    
    Margemdecrescimento = ((Futurefollows/Nowfollows)/100);
    
    Saldo = ((Futurefollows - Nowfollows)*0.3);
    
    cout << "Registro concluido, olhe as informções a seguir:"<<endl;
    
    if (Robotest == true){
        
        
        cout << "Seu nome de feiticeiro: "<< Nomedeusuario <<endl;
        cout << "Sua senha: "<< Senha <<endl;
        cout << "Sua palavra chave: "<< SobreMim <<endl;
        cout << "Sua Margem de crescimento: "<< Margemdecrescimento << ", levando em conto o numero atual de seguidores ("<<Nowfollows<<"), e o que se espera chegar(" <<Futurefollows << ")."<<endl;
        cout << "Levando em consideração a cotação de 1 terço de dollar por seguidor você terá um saldo a mais de "<< Saldo << endl;
            if ( Verificar == true){
        cout << "Conta verificada."<<endl;
        } 
            else{
        cout << "Conta não verificada."<<endl;
        }
        
        
    } else {
        cout << "Conta robotica, reinicie o programa para refazer o resgitro."<<endl;
        
    }
    
    return 0;
}








