/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      bool x=true;
      int chose = 1;
      
    while(x==true){
        int escolha, num_ajuda, cont;
        cont = 0;
        
        
        Console.WriteLine("1-Apresentar a instituição\n2-Apresentar o voluntário\n3-Adicionar as pessoas ajudadas");
        escolha = Convert.ToInt32(Console.ReadLine());
        switch(escolha){
            case 1:
                Console.WriteLine("O Asilo Amaldiçoado é um local feito para acolher feiticeiros mais velhos.");
                break;
            case 2:
                Console.WriteLine("Yuta é um voluntário que visa cuidar dos mais necessitados e indefesos.");
                break;
            case 3:
                Console.WriteLine("Quantas pessoas foram ajudadas?");
                num_ajuda = Convert.ToInt32(Console.ReadLine());
                string[] nomes = new string[num_ajuda];
                int pessoa;
                do
                {
                    pessoa = cont + 1;
                    Console.WriteLine("Qual o nome da pessoa " + pessoa + "?");
                    nomes[cont] = Convert.ToString(Console.ReadLine());
                    cont++;
                }while(cont < num_ajuda);
                for(int i = num_ajuda; i == 0; i--){
                    Console.WriteLine("Yuta ajudou " + nomes[i]);
                }
                break;
            
        }
        Console.WriteLine("Gostaria de sair do programa?\npara sim digite 1\npara não digite 2");
        chose = Convert.ToInt32(Console.ReadLine());
        if(chose == 2)
        {
            Console.WriteLine("Obrigado por utilizar nosso serviço!");
            x = false;
        }else{
            Console.WriteLine("Aproveite nosso serviços denovo!");
        }
    }
  }
}