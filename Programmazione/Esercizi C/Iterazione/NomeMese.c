/* 
testo:
Dato in input un numero intero appartenente all'intervallo 1-12
stampare il nome del mese corrispondente, ovvero errore altrimenti
In caso di errore richiedere nuovamente l'inserimento dei dati
*/

#include <stdio.h>
int main(){
	
int n;
do{

printf("inserisci un numero intero [1,12]:");
scanf("%d",&n);

if(n<1 || n>12)
   printf("\nErrore\n\n");
}while(n<1 || n>12);
switch(n){
	case 1: printf("Gennaio"); break;
	case 2: printf("Febbraio"); break;
	case 3: printf("Marzo"); break;
	case 4: printf("Aprile"); break;
	case 5: printf("Maggio"); break;
	case 6: printf("Giugno"); break;
	case 7: printf("Luglio"); break;
	case 8: printf("Agosto"); break;
	case 9: printf("Settembre"); break;
	case 10: printf("Ottobre"); break;
	case 11 :printf("Novembre"); break;
	case 12: printf("Dicembre"); break;	
	default: printf("\nErrore\n\n");
}
}
