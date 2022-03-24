/*
Dato un array di nomi di persone, si richiede di stampare la lunghezza dei nomi. 
Si consideri la funzione strlen della libreria string.h
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
	strcpy(nomi[4], "Mattia");
	
	int i;
	for(i=0;i<5;i++)
	printf("\n%s",nomi[i]);
	
	for(i=0;i<5;i++)
	printf("\nCaratteri: %d", strlen(nomi[i]));
}




