import java.util.Scanner;

public class ExercicioFinal {
    
    private static double calcularMediaArray(double[] numeros){
        double soma = 0;
        for(int i = 0; i < numeros.length; i++){
            soma += numeros[i];
        }
        return soma / numeros.length;
    }

    public static void main(String[] args) {
        Scanner leitor = new Scanner(System.in);
        int numero;
    
        System.out.println("--- Somador de Números ---");

         System.out.print("Digite um número de alunos: ");
         numero = leitor.nextInt(); 
        double[] numeros = new double[numero];

        System.out.println("Digite a nota do 1º aluno:"); 
        numeros[0] = leitor.nextDouble();

        for (int i = 1; i < numero; i++) {
            System.out.println("Digite a nota do "+(i+1)+"º aluno:"); 
            numeros[i] = leitor.nextDouble();
        }

        System.out.println("A média dos números é: " + calcularMediaArray(numeros));
        
        leitor.close();
    }

}
