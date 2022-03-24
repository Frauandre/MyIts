/*
Dato un array di stringhe, si richiedono le seguenti azioni:

stampare l'elenco con le stringhe in maiuscolo
stampare l'elenco con le stringhe in minuscolo
Si considerino le funzioni toupper e tolower della libreria ctype.h
*/

#include <stdio.h>
#include <string.h>
#include <math.h>
#include <ctype.h>

int main(){
	char nomi[5][20];
	strcpy(nomi[0], "Paolo");
	strcpy(nomi[1], "Marco");
	strcpy(nomi[2], "Gianpietro");
	strcpy(nomi[3], "Matteo");
	strcpy(nomi[4], "MATTIA");
	
	int i;
	for(i=0;i<5;i++)
	printf("\n %s",nomi[i]);
	
	for(i=0;i<5;i++)
	printf("\nMaiuscole: %s",toupper(nomi[i]));
	
	
}
