
public class ProvaScorrimentoArray {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

			//int[] voti = new int[4];
			//voti[0] =25;
		
		int[] voti = {24, 24, 23, 22};
		
		int totale = 0;
		
		for (int i = 0; i< voti.length; i++) {
			System.out.println(voti[i]);
			
		}
		
		System.out.println("Il totale dei voti è: " + totale);
		double media = totale/voti.length;
		
		System.out.println("La media totale è: " + media);
	}
	

}
