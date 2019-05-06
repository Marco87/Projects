package pot;

import java.util.Scanner;

public class HelloPotato {
	public static void main(String args[]) {

		System.out.println("Espanhol - es\nInglês - en\nPortuguês - pt");

		Scanner tec = new Scanner(System.in);
		String op = tec.nextLine();

		if (op.equals("es")) {
			System.out.println("Hola Patata!");
		} else if (op.equals("en")) {
			System.out.println("Hello Potato!");
		} else if (op.equals("pt")) {
			System.out.println("Olá Batata!");
		} else {
			System.out.println("Digite uma opção válida!");
		}
		tec.close();
	}
}