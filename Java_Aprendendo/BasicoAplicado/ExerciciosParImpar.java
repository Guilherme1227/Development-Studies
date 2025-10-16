import java.util.Scanner; // 1. Importa a classe Scanner

public class ExerciciosParImpar {
    public static void main(String[] args) {

        //variaveis
        int numero;
        
        // 2. Cria o objeto Scanner
        Scanner leitor = new Scanner(System.in); 
        System.out.print("Digite um numero: "); 
        numero = leitor.nextInt(); 


        if(numero % 2 == 0){
            System.out.println("O numero "+numero+" é par!"); // Usando println
        }
        else{
            System.out.println("O numero "+numero+" é impar!"); // Usando println
        }
        
        leitor.close(); 
    }
}