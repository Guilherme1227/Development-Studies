import java.util.Scanner;
public class ExercicioMaiorNumero {
    public static void main(String[] args) {
        
        double num1 = 0, num2 = 0, num3 = 0;

        Scanner leitor = new Scanner(System.in);

        for(int i = 0; i<3; i++){
            System.out.print("Digite o "+(i+1)+"º numero: ");
            if(i == 0){
                num1 = leitor.nextDouble();
            }
            else if(i == 1){
                num2 = leitor.nextDouble();
            }
            else{
                num3 = leitor.nextDouble();
            }
        }

        if(num1 > num2 && num1 > num3){
            System.out.println("O maior numero é: "+num1);
        }
        else if(num2 > num1 && num2 > num3){
            System.out.println("O maior numero é: "+num2);
        }
        else if(num3 > num1 && num3 > num2){
            System.out.println("O maior numero é: "+num3);
        }
        else{
            System.out.println("Os numeros são iguais");
        }
        leitor.close();
    }
}
