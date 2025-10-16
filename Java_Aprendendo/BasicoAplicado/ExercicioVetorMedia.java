import java.util.Scanner;

public class ExercicioVetorMedia {
    public static void main(String[] args) {

        double[] numeros = new double[5];
        Scanner leitor = new Scanner(System.in);

        for(int i = 0; i < 5; i++){
            System.out.print("Digite o "+(i+1)+"º numero: ");
            numeros[i] = leitor.nextDouble();
        }

        double soma = 0;
        for(int i = 0; i < 5; i++){
            soma += numeros[i];
        }

        System.out.println("A média dos números é: " + (soma / numeros.length));
        leitor.close();
    
    }

}
