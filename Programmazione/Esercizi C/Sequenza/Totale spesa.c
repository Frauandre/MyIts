/*

Stampare il totale da pagare, il numero di pezzi totali acquistati di un carrello della spesa.

*/
#include <stdio.h>
#include <math.h>
#include <timne.h>

int main(){
	
	int n;
	printf("inserisci il numero di prodotti nel carrello:");
	scanf("%d", &n);
	
	int i, quantita, contaPezzi=0;
	float prezzo, somma=0;
	
	for(i=0;i<n;i++){
		printf("inserisci il prezzo del prodotto:");
		scanf("%f",&prezzo);
		
		printf("inserisci la quantita:");
		scanf("%d",&quantita);
		
		somma+=prezzo*quantita;
		contaPezzi+=quantita;	
	}
printf("\nTotale: %2f",somma);
printf("\nPezzi acquistati: %2f",contaPezzi);	
	
	
}
