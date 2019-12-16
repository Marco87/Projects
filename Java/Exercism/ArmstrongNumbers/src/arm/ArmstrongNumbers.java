package arm;

import java.util.Scanner;

public class ArmstrongNumbers {
	public static void main(String args[]) {
		int numero, tamanhoNumero;
		String num;
		Double armst = 0.0;
		Double pot;

		Scanner tec = new Scanner(System.in);
		System.out.println("Digite um número:");
		numero = tec.nextInt();

		num = Integer.toString(numero);
		tamanhoNumero = num.length();

		for (int i = 0; i < tamanhoNumero; i++) {
			pot = Math.pow(Integer.parseInt(Character.toString(num.charAt(i))), tamanhoNumero);
			armst = armst + pot;
		}

		if (armst == numero)
			System.out.println("É um armstrong number.");
		else
			System.out.println("Não é um armstrong number.");

		tec.close();

	}
}
