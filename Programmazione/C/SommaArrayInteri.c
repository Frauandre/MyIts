/*
Riempire un array di numeri interi con dimensione e numeri dati in input.
Calcolare la somma.
Stampare il risultato
*/
#include <stdio.h>

void stampaArray(int v[],int dimensione){
	int i;
	for(i=0;i<dimensione;i++)
		printf("%d\n",v[i]);
}

int sommaArray(int v[],int dimensione){
	int i,somma=0;
	for(i=0;i<dimensione;i++)
		somma += v[i];
	return somma;
}

int main(){
	
	int n;
	printf("Inserisci quanti numeri vuoi memorizzare: ");
	scanf("%d",&n);
	
	//dichiarazione dell'array
	int numeri[n];
	
	//riempimento dell'array con dati da input
	int i;
	/*
	int numero;
	for(i=0;i<n;i++){
		printf("Inserisci un numero: ");
		scanf("%d",&numero);
		numeri[i]=numero;
	}*/
	
	for(i=0;i<n;i++){
		printf("Inserisci un numero: ");
		scanf("%d",&numeri[i]);		
	}
	
	//somma
	int somma=0;
	for(i=0;i<n;i++)
		somma +=numeri[i];	
	
	//stampa dell'array	
	printf("\n\nNumeri inseriti:\n");
	for(i=0;i<n;i++)
		printf("%d\n",numeri[i]);
	
	printf("\n\nNumeri inseriti (versione funzione):\n");
	stampaArray(numeri,n);
	
	//stampa risultato	
	printf("\nSomma: %d",somma);
	printf("\nSomma (versione funzione): %d",sommaArray(numeri,n));
}

