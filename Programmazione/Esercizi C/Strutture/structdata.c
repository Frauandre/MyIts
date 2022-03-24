/*

Costruire un tipo per rappresentare una data.

*/

#include <stdio.h>

//definizione della struttura di dati;
typedef struct data{
	int giorno;
	int mese;
	int anno;
}data;

//funzione formaDataLineare es.13/01/2022
void formaDataLineare(data unaData){
	printf("%d/%d/%d",giorno,mese,anno);
	
	if(unaData.giorno<10)
	printf("0");
	printf("%d", giorno);
	
	if(unaData.mese<10)
	printf("0");
	printf("%d", mese);
	printf("%d", anno);
	return 0;
	
}

int IsDataValid(int giorno, int mese, int anno){
	return 0;
}

int main(){
	
	//serve per definire un nuovo tipo di dato
	data oggi;
	
	int giorno;
	printf("inserisci il giorno: ");
	scanf("%d", &oggi.giorno);
	//oggi.giorno=giorno;
	
	int mese;
	printf("inserisci il mese: ");
	scanf("%d", &oggi.mese);
	//oggi.mese=mese;
	int anno;
	printf("inserisci anno: ");
	scanf("%d", &oggi.anno);
	//oggi.anno=anno;
	
	formaDataLineare(giorno,mese,anno);
	
}































































