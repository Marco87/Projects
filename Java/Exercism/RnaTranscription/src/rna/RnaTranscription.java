package rna;

import java.util.Scanner;

public class RnaTranscription {
	public static void main(String args[]) {
		Scanner tec = new Scanner(System.in);
		String rnaStrand;

		System.out.println("Digitar o DNA: ");
		String dnaStrand = tec.next();
		
		rnaStrand = dnaStrand.replace("G", "c1").replace("C", "G").replace("T", "a1").replace("A", "U");
		rnaStrand = rnaStrand.replace("a1", "A").replaceAll("c1", "C");
		System.out.println("DNA: " + dnaStrand + "\nRNA: " + rnaStrand);
		
		tec.close();
	}
}
