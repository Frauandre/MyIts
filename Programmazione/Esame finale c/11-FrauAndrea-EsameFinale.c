/*
	
	ESAME FINALE.
	
	Testo:

	Si consideri il file Studenti.csv. Si richiede la costruzione di un software che consenta le seguenti operazioni:

	stampa dell'elenco degli studenti
	stampa dell'elenco dei soli studenti di una certa classe (data in input)
	visualizzare l'elenco degli studenti che hanno il cognome che inizia con una certa lettera data in input
	raggruppare gli studenti per classe e visualizzare il risultato
	creare un file di testo(studenti-quarta.txt) per stampare un elenco di studenti appartenenti alla classe quarta.

*/


#include <stdio.h>
#include <string.h>


	//DEFINISCO LA STRUTTURA IN BASE AI DATI DELLO STUDENTE
typedef struct{
	char matricola[10];
	char nome[20];
	char cognome[20];
	char email[50];
	char classe[3];
}studente;


	//STAMPA DEI DATI DEL SINGOLO STUDENTE
void stampaStudente(studente s){
	printf("Nmat: %s - Nome: %s - Cognome: %s - Email: %s - Classe: %s",s.matricola,s.nome,s.cognome,s.email,s.classe);
}


	//STAMPA L'ELENCO DI TUTTI GLI STUDENTI
void stampaElencoStudenti(studente elenco[],int dimensione){
	
	int i;
	for(i=0;i<dimensione;i++){
		stampaStudente(elenco[i]);
		printf("\n");
	}
}


	//RICERCA DEL COGNOME DELLO STUDENTE TRAMITE UNA LETTERA INIZIALE
void ricercaCognome(studente elenco[], int dimensione, char iniziale){
	
	int i;
	for(i=0;i<dimensione;i++)
		if(toupper((int)elenco[i].cognome[0])==toupper((int)iniziale)){
			stampaStudente(elenco[i]);
			printf("\n");
		}
}


	//RICERCA DEGLI STUDENTI APPARTENENTI ALLA STESSA ANNUALITA'
	//OPPURE APPARTENENTI ALLA STESSA CLASSE E SEZIONE
void ricercaClasse(studente elenco[], int dimensione, char iniziale){
	
	int i;
	for(i=0;i<dimensione;i++)
		if(toupper((int)elenco[i].classe[0])==toupper((int)iniziale)){
			stampaStudente(elenco[i]);
			printf("\n");
		}
}


	//RESTITUISCE L'ELENCO DELLE OPERAZIONI DESIDERATE
void stampaMenu(){
	printf("Scegli una delle seguenti operazioni da eseguire:");
	printf("\n 1 - Stampa l'elenco degli studenti");
	printf("\n 2 - Stampa l'elenco degli studenti appartenenti ad una classe");
	printf("\n 3 - Stampa l'elenco degli studenti con una certa iniziale");
	printf("\n 0 - Termina l'esecuzione");
}



int main(){
	
	//ELENCO DEI DATI DELLO STUDENTE 
	studente s[10]={
	{"11258","Piero","Giuliani","giuliani.piero@studenti.itis.net","1A"},
	{"11259","Laura","De Stena","destena.laura@studenti.itis.net","2A"},
	{"11260","Giulia","Caruso","caruso.giulia@studenti.itis.net","4C"},
	{"11261","Francesco","Cocco","cocco.francesco@studenti.itis.net","1B"},
	{"11262","Giulio","Marchese","marchese.giulio@studenti.itis.net","4C"},
	{"11263","Mauro","Marchesato","marchesato.mauro@studenti.itis.net","3B"},
	{"11264","Maurizio","Conciellio","conciello.murizio@studenti.itis.net","4D"},
	{"11265","Andrea","De Blasi","deblasi.andrea@studenti.itis.net","1B"},
	{"11266","Lorena","Di Stefano","di stefano.lorena@studenti.itis.net","5A"},
	{"11266","Maria","Balocco","balocco.maria@studenti.itis.net","5B"}
	};
	
	
	char c;
	int numero;
	
	//COSTRUZIONE DEL MENU' DI SCELTA
	do{
		stampaMenu();
		printf("\n\nScelta: ");
		scanf("%d",&numero);
		
						
		switch(numero){
			case 0: //
			
				printf("\nProgramma terminato. ");
				break;
				
			case 1: 
				
				printf("\nElenco degli studenti: \n");
				stampaElencoStudenti(s,10);	
				break;
				
			case 2: 
			
				printf("\nInserisci la classe da cercare: ");
				scanf("%s",&c);
	
				printf("\n\nCorrispondenza Studenti: \n");
				ricercaClasse(s,10,c);
				break;
					
			case 3: 
				
				printf("\nInserisci l'iniziale da cercare: ");
				scanf("%s",&c);
				
				printf("\nCorrispondenza Studenti: \n");
				ricercaCognome(s,10,c);
				break;
						
			default: printf("ERRORE! Valore inserito non valido!");
		}
		
		printf("\n\n");
		
	}while(numero!=0);
	
}
