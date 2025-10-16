import java.util.Scanner;

public class ExercicioAposentadoria {
    

    public static void main(String[] args) {

    int idade, tempContribuicao;

    Scanner leitor = new Scanner(System.in);
    System.out.print("Digite sua idade: ");
    idade = leitor.nextInt();

    System.out.print("Digite seu tempo de contribuição: ");
    tempContribuicao = leitor.nextInt();

    if(idade>= 65 || tempContribuicao >= 30){
        System.out.println("Apto para aposentadoria");
    }
    else{
        System.out.println("Não apto para aposentadoria");
    }

    leitor.close();
}

}
