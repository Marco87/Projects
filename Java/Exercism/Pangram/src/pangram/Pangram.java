package pangram;

import java.util.Scanner;

public class Pangram {
	public static void main(String args[]) {
		Scanner tec = new Scanner(System.in);
		String palavra;

		System.out.println("Escreva uma frase: ");
		palavra = tec.nextLine().toUpperCase();
		tec.close();

		if (palavra.contains("A") && palavra.contains("B") && palavra.contains("C") && palavra.contains("D")
				&& palavra.contains("E") && palavra.contains("F") && palavra.contains("G") && palavra.contains("H")
				&& palavra.contains("I") && palavra.contains("J") && palavra.contains("K") && palavra.contains("L")
				&& palavra.contains("M") && palavra.contains("N") && palavra.contains("O") && palavra.contains("P")
				&& palavra.contains("Q") && palavra.contains("R") && palavra.contains("S") && palavra.contains("T")
				&& palavra.contains("U") && palavra.contains("V") && palavra.contains("W") && palavra.contains("X")
				&& palavra.contains("Y") && palavra.contains("Z")) {
			System.out.println("É Pangram!");
		} else {
			System.out.println("Não é Pangram!");
		}

	}
}
