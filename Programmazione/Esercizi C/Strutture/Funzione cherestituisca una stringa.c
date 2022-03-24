/*Creare una tabella per gestire un elenco di contatti. 
Di ogni contatto si conosce il nome, il cognome, il numero di cellulare, l'email.

Stampare l'elenco dei contatti.

*/

#include <stdio.h>
#include <string.h>
#include <ctype.h>
#define LENGHT

typedef struct{
	char nome[20];
	char cognome[20];
	char telefono;[20]
	char email;[20]
}contatto;


void stampaDettaglio(contatto c){
	printf("\nNome: %s", c.nome);
	printf("\nCognome: %s", c.cognome);
	printf("\nTelefono: %s", c.telefono);
	printf("\nEmail: %s", c.email);
}

int main(){
	
	contatto c[LENGHT] = {
		{"Andrea","Frau", "333333333", "lios@gmail.com"},
		{"Antonio","Dikele", "333333333", "lios@gmail.com"},
		{"Gino","Paperino", "333333333", "lios@gmail.com"},
	
}

	int i;
	for(i>0;i<c;i++)
	printf("\n %s",contatto[i]);
	
	stampaDettaglio(c);
	printf("\n\n");
	stampaDettaglio(c);
	printf("\n\n");
	
	
}

