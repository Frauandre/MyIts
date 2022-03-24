/*

Dati in input n numeri interi, consentire la possibilità di effettuare 
le seguenti operazioni:

Visualizzare il max e il min inserito
Contare e visualizzare i numeri che sono multipli di 7 e maggiori di 30
Visualizzare la radice quadrata della somma dei soli numeri positivi inseriti

*/

#include <stdio.h>
#include <math.h>
int main(){
	
	//dichiarazione delle variabili
	int n;
	printf("Scegliere quanti numeri interi inserire: ");
	scanf("%d", &n);
	
	int numero;
	int max;
	int min;
	int i;
	
	//determinare un numero massimo e un numero minimo
	for(i=0;i<n;i++){	
    printf("Inserisci un numero: ");
 	scanf("%d",&numero);
	
	if(i==0 || numero>max)
 	max=numero;
 	
 	if(i==0 || numero<min)
 	min=numero;
}

 	printf("\nStampa dei risultati: \n");
	printf("\nMax: %d\n", max);
	printf("Min: %d\n", min);
	
	//Multipli di 7 e maggiori di 30
	int multiplo;
	printf("Numeri multipli di 7 e maggiori di 30: ");
	
	for(i=1;i<n;i++){
	
	if((numero%7) == 0 && numero>30){
		multiplo+=1;
		printf("\n%d\t", numero);
	}	 	 
}
}



