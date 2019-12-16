package rain;

import java.util.Scanner;

public class Raindrops {
	public static void main(String[] args) {
		Scanner tec = new Scanner(System.in);
		int n, i = 0;
		String rd = "";

		System.out.println("Digite um número: ");
		n = tec.nextInt();

		if (n % 3 == 0) {
			rd += "Pling";
			i++;
		}
		if (n % 5 == 0) {
			rd += "Plang";
			i++;
		}
		if (n % 7 == 0) {
			rd += "Plong";
			i++;
		}
		if (i == 0)
			rd = Integer.toString(n);

		System.out.println(rd);

	}
}
