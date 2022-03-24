/*
tipo di dato: studente(matricola, nome, cognome, eta)

creare un software per stampare i dati di tre studenti
utilizzare per la stampa la stampaDettaglio

*/
#include <stdio.h>
#include <string.h>

typedef struct{
	int matricola;
	char nome[20];
	char cognome[20];
	int Eta;
}studente;


void stampaDettaglio(studente s){
	printf("\nMatricola: %d",s.matricola);
	printf("\nNome: %s", s.nome);
	printf("\nCognome: %s", s.cognome);
	printf("\nEta: %d", s.Eta);
}

void stampaLineare(studente s){
	printf("\nMatricola: %d",s.matricola);
	printf("\nNome: %s", s.nome);
	printf("\nCognome: %s", s.cognome);
	printf("\nEta: %d", s.Eta);
}

int main(){
	
	studente s1,s2,s3;
	
	s1.matricola=123456;
	strcpy(s1.nome, "Iulian");
	strcpy(s1.cognome, "Donea");
	s1.Eta=12;
	
	s2.matricola=123456;
	strcpy(s2.nome, "Antonio");
	strcpy(s2.cognome, "Del Sonno");
	s2.Eta=12;
	
	s3.matricola=123456;
	strcpy(s3.nome, "Giuseppe");
	strcpy(s3.cognome, "Dominici");
	s3.Eta=12;
	
	
	stampaDettaglio(s1);
	printf("\n\n");
	stampaDettaglio(s2);
	printf("\n\n");
	stampaDettaglio(s3);
	printf("\n\n");
	
	stampaLineare(s1);
	printf("\n\n");
	stampaLineare(s2);
	printf("\n\n");
	stampaLineare(s3);
	printf("\n\n");
	
}
