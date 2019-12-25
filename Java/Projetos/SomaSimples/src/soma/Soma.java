package soma;

import java.util.Scanner;

public class Soma {

	int x1;
	int x2;

	Scanner tec = new Scanner(System.in);

	public void calcular() {
		setX1(validarNumeros());
		setX2(validarNumeros());
	}

	public int validarNumeros() {
		int x = 0;
		System.out.println("Informe o número: ");

		try {
			x = (tec.nextInt());
			return x;
		} catch (Exception e) {
			System.out.println("Digite apenas números!");
			tec.close();
			return x;
		}
		
	}

	public int somar() {
		return getX1() + getX2();
	}

	public int getX1() {
		return x1;
	}

	public void setX1(int x1) {
		this.x1 = x1;
	}

	public int getX2() {
		return x2;
	}

	public void setX2(int x2) {
		this.x2 = x2;
	}
}
