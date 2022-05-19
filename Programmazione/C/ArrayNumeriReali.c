/* array di numeri interi */
#include <stdio.h>

int main(){
	
	//dichiarazione di un array
	//tipo identificatore[dimensione];
	float numeri[5]; //dichiaro un array di numeri interi di dimensione 5 (celle)
	
	//caricamento di un array
	numeri[0]=12;
	numeri[1]=-4;
	numeri[2]=9;
	numeri[3]=-11;
	numeri[4]=3;
	
	//lettura di un valore in un array
	int i;
	printf("Stampa dell'array");
	for(i=0;i<5;i++)
		printf("\nPosizione: %d; valore: %f",i,numeri[i]);
	
	
	printf("\n\nStampa dell'indirizzo di memoria dell'array'");	
	for(i=0;i<5;i++)
		printf("\nPosizione: %d; indirizzo: %d",i,&numeri[i]);
		
}
