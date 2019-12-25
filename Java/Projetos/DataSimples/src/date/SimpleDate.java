package date;

import java.util.Calendar;

public class SimpleDate {

	public static void main(String args[]) {
		Calendar data = Calendar.getInstance();
		System.out.println(data.getTime());
		
		data.add(Calendar.SECOND, 1000000000);
		System.out.println(data.getTime());
	}
}
