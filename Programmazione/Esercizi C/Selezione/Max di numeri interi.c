/* 
testo:
Determinare il max di una serie di numeri reali dati in input
*/

#include <stdio.h>
int main(){
	
int n;

int flag; //stato dell'errore
do{
   	flag=0; //non ci sono errori
	printf("inserisci quanti numeri:");
	scanf("%d",&n);

if(n<=0)
   printf("\nErrore\n\n");
   flag=1; //si è verificato un errore
}while(flag==1);

int max=0;
int i; //indice contatore per il ciclo for
int numero; // variabile per acquisire da input il numero di volta in volta

for(i=0;i<n;i++){
    printf("inserisci un numero:");
	 scanf("%d",&numero);
	
	if(i==0 || numero>max)
	  max=numero;
}
printf("\nStampa dei risultati\n\n");
printf("\nmax: %lf\n", max);

}
