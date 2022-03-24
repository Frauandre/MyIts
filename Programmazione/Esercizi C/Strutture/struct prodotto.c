/*

Costruire un tipo per rappresentare un prodotto.

un prodotto è composto da:
un codice numerico
un nome di lunghezza massima 50 caratteri
un prezzo
una giacenza

creare una variabile di tipo prodotto e stampare il risultato.

*/

#include <stdio.h>
#include <string.h>

typedef struct{
	int codice;
	char nome[50];
	float prezzo;
	int giacenza;
}prodotto;

int main(){
	
	prodotto p;
	
	p.codice=1;
	p.prezzo=12.50;
	p.giacenza=25;
	strcpy(p.nome, "Prodotto1");
	
	printf("Dati del prodotto:\n");
	printf("Codice: %d\n",p.codice);
	printf("Nome: %s\n",p.nome);
	printf("Prezzo: %lf\n",p.prezzo);
	printf("Giacenza: %d\n",p.giacenza);
}


