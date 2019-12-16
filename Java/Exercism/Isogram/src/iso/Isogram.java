package iso;

import java.util.Scanner;

public class Isogram {

	public static void main(String[] args) {
		Scanner tec = new Scanner(System.in);
		String palavra;
		boolean iso = true;

		System.out.println("Digite uma palavra/frase:");
		palavra = tec.nextLine();

		char[] p = palavra.toCharArray();

		for (int i = 0; i < palavra.length(); i++) {
			for (int j = 0; j < palavra.length(); j++) {
				if (((p[i] == p[j]) && i != j)
						&& (p[j] != '-' && p[j] != '.' && p[j] != ',' && p[j] != '_' && p[j] != '+' && p[j] != ' '))
					iso = false;
			}
		}
		if (iso)
			System.out.println("É um Isogram!");
		else
			System.out.println("Não é um Isogram!");

		tec.close();
	}
}
