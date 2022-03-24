/* 
testo:
Calcolare la media aritmetica e geometrica di n numeri interi dati in input
Visualizzare i risultati
*/

#include <stdio.h>
int main(){
	
int n;
int flag; //stato dell'errore
do{
   	flag=0; //non ci sono errori
	printf("inserisci un numero intero strettamente positivo (>0):");
	scanf("%d",&n);

if(n<=0)
   printf("\nErrore\n\n");
   flag=1; //si è verificato un errore
}while(flag==1);
int somma=0; //default per una variabile sommatore (somma)
int prodotto=1; //default per una variabile prodotto (moltiplicazione)

int i; //indice contatore per il ciclo for
int numero; // variabile per acquisire da input il numero di volta in volta
for(i=0;i<n;i++){
	printf("inserisci un numero:");
	scanf("%d",&numero);
	
	somma+=numero;
	prodotto*=numero;
}
double mediaAritmetica= (double)somma/n;
double mediaGeometrica= (double)prodotto/n;
printf("\nmediaAritmetica: %lf\n", mediaAritmetica);
printf("\nmediaGeometrica: %lf\n", mediaGeometrica);
}
