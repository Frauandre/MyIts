/*
Definire un nuovo tipo di dato per l'editore

Dell'editore si conosce:
codice int
ragione sociale stringa
indirizzo stringa
email stringa
sito web stringa
numero di telefono stringa
*/

#include <string.h>
#include <stdio.h>

typedef struct{
	int codice;
	char ragioneSociale[50];
	char indirizzo[50];
	char email[50];
	char sitoWeb[50];
	char telefono[50];
}editore;


void stampaEditore(editore e1){
	printf("\nCodice: %d", e1.codice);
	printf("\nragioneSociale: %s", e1.ragioneSociale);
	printf("\nIndirizzo: %s", e1.indirizzo);
	printf("\nEmail: %s", e1.email);
	printf("\nSitoWeb: %s", e1.sitoWeb);
	printf("\nTelefono: %s", e1.telefono);
}


int main(){
	
	editore e1;
	
	e1.codice=1;
	strcpy(e1.ragioneSociale, "Hoepli");
	strcpy(e1.indirizzo, "Via dei Mille, 101 - 10100 Torino (TO)");
	strcpy(e1.email, "info@hoepli.it");
	strcpy(e1.sitoWeb, "https://www.hoepli.it");
	strcpy(e1.telefono, "011 456596684");
	
	editore e2 = {2, "Atlas", "Via Durandi "info@atlas.it", "https://www.atlas.it", "011 4572448784"};
	
	stampaEditore(e1);
	printf("\n\n");
	stampaEditore(e2);
	
}
