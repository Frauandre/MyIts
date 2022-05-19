/*
Riempire un array di numeri interi con dimensione e numeri dati in input.
Calcolare la media aritmetica dei numeri memorizzati strettamente positivi.
Stampare il risultato
*/
#include <stdio.h>

void stampaArray(int v[],int dimensione){
	int i;
	for(i=0;i<dimensione;i++)
		printf("%d\n",v[i]);
}

int sommaSoloPositiviArray(int v[],int dimensione){
	int i,somma=0;
	for(i=0;i<dimensione;i++)
		if(v[i]>0)
			somma += v[i];
	return somma;
}

int contaSoloPositiviArray(int v[],int dimensione){
	int i,conta=0;
	for(i=0;i<dimensione;i++)
		if(v[i]>0)
			conta++;
	return conta;
}

int main(){
	
	int n;
	printf("Inserisci quanti numeri vuoi memorizzare: ");
	scanf("%d",&n);
	
	//dichiarazione dell'array
	int numeri[n];
	
	//riempimento dell'array con dati da input
	int i;
	for(i=0;i<n;i++){
		printf("Inserisci un numero: ");
		scanf("%d",&numeri[i]);		
	}
	
	//somma e conta positivi
	int sommaPositivi=0, contaPositivi=0;
	for(i=0;i<n;i++)
		if(numeri[i]>0){
			sommaPositivi += numeri[i];
			contaPositivi++;
		}
	
	//calcolo della media
	float media = (float)sommaPositivi/contaPositivi;
		
	//uso le funzioni
	float media1 = (float)sommaSoloPositiviArray(numeri,n)/contaSoloPositiviArray(numeri,n);
	
	//stampa risultato	
	printf("\nMedia: %f",media);
	printf("\nMedia (uso funzioni): %f",media1);	
}

