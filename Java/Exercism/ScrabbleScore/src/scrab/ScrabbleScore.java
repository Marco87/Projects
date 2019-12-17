package scrab;

import java.util.Scanner;

public class ScrabbleScore {

	public static void main(String[] args) {
		Scanner tec = new Scanner(System.in);
		String palavra;
		int scrab = 0;

		System.out.println("Digite uma palavra:");
		palavra = tec.nextLine();

		palavra = palavra.toUpperCase();

		char[] p = palavra.toCharArray();

		for (int i = 0; i < palavra.length(); i++) {
			switch (p[i]) {
			case 'A':
				scrab += 1;
				break;
			case 'E':
				scrab += 1;
				break;
			case 'I':
				scrab += 1;
				break;
			case 'O':
				scrab += 1;
				break;
			case 'U':
				scrab += 1;
				break;
			case 'L':
				scrab += 1;
				break;
			case 'N':
				scrab += 1;
				break;
			case 'R':
				scrab += 1;
				break;
			case 'S':
				scrab += 1;
				break;
			case 'T':
				scrab += 1;
				break;
			case 'D':
				scrab += 2;
				break;
			case 'G':
				scrab += 2;
				break;
			case 'B':
				scrab += 3;
				break;
			case 'C':
				scrab += 3;
				break;
			case 'M':
				scrab += 3;
				break;
			case 'P':
				scrab += 3;
				break;
			case 'F':
				scrab += 4;
				break;
			case 'H':
				scrab += 4;
				break;
			case 'V':
				scrab += 4;
				break;
			case 'W':
				scrab += 4;
				break;
			case 'Y':
				scrab += 4;
				break;
			case 'K':
				scrab += 5;
				break;
			case 'J':
				scrab += 8;
				break;
			case 'X':
				scrab += 8;
				break;
			case 'Q':
				scrab += 10;
				break;
			case 'Z':
				scrab += 10;
				break;
			default:
				scrab += 0;
			}
			/*
			 * if (p[i] == 'A' || p[i] == 'E' || p[i] == 'I' || p[i] == 'O' || p[i] == 'U'
			 * || p[i] == 'L' || p[i] == 'N' || p[i] == 'R' || p[i] == 'S' || p[i] == 'T')
			 * scrab += 1; else if (p[i] == 'D' || p[i] == 'G') scrab += 2; else if (p[i] ==
			 * 'B' || p[i] == 'C' || p[i] == 'M' || p[i] == 'P') scrab += 3; else if (p[i]
			 * == 'F' || p[i] == 'H' || p[i] == 'V' || p[i] == 'W' || p[i] == 'Y') scrab +=
			 * 4; else if (p[i] == 'K') scrab += 5; else if (p[i] == 'J' || p[i] == 'X')
			 * scrab += 8; else if (p[i] == 'Q' || p[i] == 'Z') scrab += 10; else scrab +=
			 * 0;
			 */
		}

		System.out.println("A palavra " + palavra + " fez " + scrab + " pontos!");

		tec.close();
	}
}
