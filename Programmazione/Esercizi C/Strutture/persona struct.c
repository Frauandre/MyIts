/*
Definire un nuovo tipo di dato persona
una persona ha: nome, cognome, data e luogo di nascita, e un codice fiscale
Si richiede di creare due variabili di tipo persona, di acquisire i dati da
tastiera e di stampare idati in dettaglio e lineare in ordine crescente per età
*/

#include <stdio.h>
#include <string.h>

//definizione della struttura di dati: data
typedef struct{
	int giorno;
	int mese;
	int anno; 
}data;

//funzione formatDataLineare es. 13/01/2022
void formatDataLineare(data unaData){
	if(unaData.giorno<10)
		printf("0");
	printf("%d/",unaData.giorno);
	if(unaData.mese<10)
		printf("0");
	printf("%d/",unaData.mese);
	printf("%d",unaData.anno);
}

//funzione formatDataLetterale es. 13 Gennaio 2022
void formatDataLetterale(data unaData){
	
	char mesi[12][9]={"Gennaio","Febbraio","Marzo","Aprile","Maggio","Giugno","Luglio"
		,"Agosto","Settembre","Ottobre","Novembre","Dicembre"};
		
	printf("%d %s %d",unaData.giorno,mesi[unaData.mese-1],unaData.anno);
}

int isDataValida(data unaData){
	//restituisce 0 se si verifica un errore
	//restituisce 1 se non ci sono errori
	
	//cerco l'errore
	if(unaData.giorno<1 || unaData.giorno>31 || unaData.mese<1 || unaData.mese>12 || unaData.anno < 1582)
		return 0;
	else if((unaData.mese==4 || unaData.mese==6 || unaData.mese==9 || unaData.mese==11) && unaData.giorno==31)
		return 0;
	else if (unaData.mese==2 && unaData.giorno>=30)
		return 0;
	else if (unaData.mese==2 && unaData.giorno==29 && unaData.anno%4!=0)
		return 0;	
	return 1;
}



typedef struct{
	char nome[20];
	char cognome[20];
	int data;
	char luogo;
	char codF;
}persona;


void stampaDettaglio(persona p){
	printf("\nNome: %s", p.nome);
	printf("\nCognome: %s", p.cognome);
	printf("\nData: %d", p.data);
	printf("\nLuogo: %s", p.luogo);
	printf("\nCodice Fiscale: %s", p.codF);
}

void stampaLineare(persona p){
	printf("\nNome: %s", p.nome);
	printf("\nCognome: %s", p.cognome);
	printf("\nData: %d", p.data);
	printf("\nLuogo: %s", p.luogo);
	printf("\nCodice Fiscale: %s", p.codF);
}

int calcoloEta(data unaData){
	data oggi;
	oggi.anno=2022;
	oggi.mese=1;
	oggi.giorno=18;
	
	int eta=oggi-unaData.anno;
	
	if(unaData.mese>oggi.mese) || (unaData.mese==oggi.mese && unaData.giorno>oggi.giorno))
 	eta--;
 	
 	return eta;
}
int main(){
	persona p1,p2;
	
	p1.codF=123456;
	strcpy(p1.nome, "Iulian");
	strcpy(p1.cognome, "Donea");
	p1.data;
	
	p2.codF=123456;
	strcpy(p2.nome, "Antonio");
	strcpy(p2.cognome, "Del Sonno");
	s2.Eta=12;
	
	
	stampaDettaglio(p1);
	printf("\n\n");
	stampaDettaglio(p2);
	printf("\n\n");
	
	stampaLineare(p1);
	printf("\n\n");
	stampaLineare(p2);
	printf("\n\n");
	
	
}
