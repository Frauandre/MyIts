/*
Dati in input il prezzo e la quantità di un certo prodotto, determinare 
la fascia di sconto da applicare e stampare i dati inseriti, la percentuale 
di sconto applicata, lo sconto effettuato e il totale da pagare.

Fasce di sconto

Quantita < 3  --- percentuale di sconto 0%
3<= Quantita < 8 --- percentuale di sconto 4%
8<= Quantita < 12 --- percentuale di sconto 9%
12<= Quantita < 20 --- percentuale di sconto 13%
Quantita >= 20 --- percentuale di sconto 21%

*/

#include <stdio.h>
#include <math.h>
#include <float.h>

int main(){
	
	int quantita;
	int percentualeSconto;
	double prezzo;
	double prezzoFinale;
	double prezzoScontato;
	double sconto;
	
	printf("Inserisci il prezzo: ");
	scanf("%lf", &prezzo);
	
	printf("Inserisci quanti prodotti: ");
	scanf("%d", &quantita);
	
	if(quantita<3){
		printf("Lo sconto e dello 0%");
		percentualeSconto=0;
		prezzoFinale=prezzo*quantita;
		printf("\nPrezzo finale: %lf", prezzoFinale);
	}
	
	if(quantita>=3 && quantita<8){
		printf("Lo sconto e del 4%");
		percentualeSconto=4;
		sconto=(prezzo*percentualeSconto)/100;
		prezzoScontato=prezzo-sconto;
		printf("\nPrezzo scontato: %lf", prezzoScontato);
		prezzoFinale=prezzoScontato*quantita;
		printf("\nPrezzo finale: %lf", prezzoFinale);
	}
	
		if(quantita>=8 && quantita<12){
		printf("Lo sconto e del 9%");
		percentualeSconto=9;
		sconto=(prezzo*percentualeSconto)/100;
		prezzoScontato=prezzo-sconto;
		printf("\nPrezzo scontato: %lf", prezzoScontato);
		prezzoFinale=prezzoScontato*quantita;
		printf("\nPrezzo finale: %lf", prezzoFinale);
		}
		
		if(quantita>=12 && quantita<20){
		printf("Lo sconto e del 13%");
		percentualeSconto=13;
		sconto=(prezzo*percentualeSconto)/100;
		prezzoScontato=prezzo-sconto;
		printf("\nPrezzo scontato: %lf", prezzoScontato);
		prezzoFinale=prezzoScontato*quantita;
		printf("\nPrezzo finale: %lf", prezzoFinale);
		}
		
		if(quantita>=20){
		printf("Lo sconto e del 21%");
		percentualeSconto=21;
		sconto=(prezzo*percentualeSconto)/100;
		prezzoScontato=prezzo-sconto;
		printf("\nPrezzo scontato: %lf", prezzoScontato);
		prezzoFinale=prezzoScontato*quantita;
		printf("\nPrezzo finale: %lf", prezzoFinale);
		}
		
	

	
}
