/*Creare una tabella per gestire un elenco di contatti. Di ogni contatto si conosce il nome, il cognome, il numero di cellulare, l'email.

Stampare l'elenco dei contatti.
Stampare l'elenco dei contatti che iniziano con una certa lettera dell'alfabeto.
Stampare l'elenco dei contatti che hanno un certo cognome (si usi la funzione strcmp della libreria string.h)

*/

#include <stdio.h>
#include <string.h>

typedef struct {
	char nome[30];
	char cognome[30];
	int telefono;
	char email[30];
}contatto;

void stampaContatto(contatto c){
	printf("\nNome: %s", c.nome);
	printf("\nCognome: %s", c.cognome);
	printf("\nTelefono: %d", c.telefono);
	printf("\nEmail: %s", c.email);
}

void stampaElenco(contatto elenco[],int dimensione){
	
	int i;
	for(i=0;i<dimensione;i++){
		stampaContatto(elenco[i]);
		printf("\n");
	}
}

void stampaElencoRicerca(contatto elenco[], int dimensione, char iniziale){
	
	int i;
	for(i=0;i<dimensione;i++)
		if(toupper((int)elenco[i].cognome[0])==toupper((int)iniziale)){
			stampaContatto(elenco[i]);
			printf("\n");
		}
}



int main(){
	
	contatto rubrica[10]={
	{"Paulo","Dybala","3383945789","paulo.dybala@gmail.com"},
	{"Dusan","Vlahovic","339450001","dusan.vlahovic@gmail.com"},
	{"Alvaro","Morata","3383945789","alvaro.morata@gmail.com"},
	{"Denis","Zakaria","338123456","denis.zakaria@gmail.com"},
	{"Federico","Chiesa","3383945789","federico.chiesa@gmail.com"},
	{"Juan","Cuadrado","3383945789","juan.cuadrado@gmail.com"},
	{"Federico","Bernardeschi","33811144556","federico.bernardeschi@gmail.com"},
	{"Matthjs","De ligt","3378945631","matthjs.deligt@gmail.com"},
	{"Giorgio","Chiellini","3384455896","giorgio.chiellini@gmail.com"},
	{"Massimiliano","Allegri","3311111456","massimiliano.allegri@gmail.com"}
	};
	
	printf("\nElenco della rubrica\n");
	stampaElenco(rubrica, 10);
	
	char c;
	printf("\n\nInserisci l'iniziale da cercare: ");
	scanf("%c",&c);
	
	printf("\nElenco della rubrica per la ricerca eseguita\n");
	stampaElencoRicerca(rubrica,10,c);
	
	
}
