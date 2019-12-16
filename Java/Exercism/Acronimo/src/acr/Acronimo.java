package acr;

import java.util.Scanner;

public class Acronimo {
	public static void main(String args[]) {
		Scanner tec = new Scanner(System.in);
		String palavra, acronimo = "";

		System.out.println("Digite uma palavra: ");
		palavra = tec.nextLine();

		palavra = palavra.replace(",", " ").replace(".", " ").replace("-", " ").replace(":", " ").replace(";", " ")
				.replace("=", " ").replace("+", " ").replaceAll("/", " ");

		String[] p = palavra.split("[,.-:;=+/] *| +");

		for (String i : p) {
			if (i != null || i != "") {
				acronimo = acronimo + i.substring(0, 1).toUpperCase();
			}
		}
		tec.close();

		System.out.println(acronimo);
	}
}
