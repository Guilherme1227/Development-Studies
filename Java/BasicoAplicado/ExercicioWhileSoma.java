import java.util.Scanner;

public class ExercicioWhileSoma {

    public static void main(String[] args) {

        int numero, soma = 0;

        Scanner leitor = new Scanner(System.in);

        System.out.println("--- Somador de Números ---");
        System.out.print("Digite um número (0 para finalizar): "); 

        numero = leitor.nextInt();

        while (numero != 0) {
            soma += numero;
            System.out.print("Digite o próximo número (0 para finalizar): ");
            numero = leitor.nextInt();
        }

        System.out.println("A soma dos numeros é: " + soma);
        leitor.close();
        
    }
}