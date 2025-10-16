import java.util.Scanner;

public class ExercicioMediaFuncao {

    public static double calcularMediaArray(double num1, double num2){
        return (num1 + num2) / 2;
    }

    public static void main(String[] args){

        Scanner leitor = new Scanner(System.in);

        int x, y;

        System.out.print("Digite o primeiro numero: ");
        x = leitor.nextInt();
        System.out.print("Digite o segundo numero: ");
        y = leitor.nextInt();

        System.out.println("A média dos numeros é: " + calcularMediaArray(x, y));
        leitor.close();

    }

}
