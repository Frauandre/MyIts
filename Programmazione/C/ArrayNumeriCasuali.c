/*
Riempire un array di numeri interi con dimensione data in input generati casualmente.
Stampare il risultato
*/
#include <stdio.h>
#include <math.h>
#include <time.h>

int main(){
	
	int n;
	printf("Inserisci quanti numeri generare casualmente: ");
	scanf("%d",&n);
	
	int numeri[n];
	
	//caricamento dell'array
	srand(time(NULL));
	
	int i;
	for(i=0;i<n;i++)
		numeri[i]=rand();
		
	printf("\n\nNumeri generati:\n");
	for(i=0;i<n;i++)
		printf("%d\n",numeri[i]);
}

