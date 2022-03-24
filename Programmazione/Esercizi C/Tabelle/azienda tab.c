#include <stdio.h>
#include <stdbool.h>
#include <string.h>

#define DIM 10

typedef enum {Alimentari,Giocattoli,Edicola,Abbigliamento} reparto;

typedef struct {
	reparto collocazione;
	int codice;
	char nome[30];
	char descrizione[250];
	float prezzo;
	int giacenza;
	bool nuovo;
	int sconto; //percentuale es 22%
}prodotto;

void stampa(prodotto p){
	printf("Reparto: ");
	switch(p.collocazione){
		case Alimentari: printf("Alimentari");break;
		case Giocattoli: printf("Giocattoli");break;
		case Edicola: printf("Edicola");break;
		case Abbigliamento: printf("Abbigliamento");break;
	}
	printf(", Codice: %d, Nome: %s, Descrizione: %s, Prezzo: %.2f, Giacenza: %d, Nuovo: ",p.codice,p.nome,p.descrizione,p.prezzo,p.giacenza);
	if(p.nuovo==true) 
		printf("si");
	else 
		printf("no");
	printf(", Sconto: %d%c",p.sconto,37);
	
}

//stampa elenco di tutti i consulenti
void stampaElenco(prodotto elenco[], int dimensione){
	
	int i;
	for(i=0;i<dimensione;i++){
		if(i!=0) 
			printf("\n");
		stampa(elenco[i]);
	}		
}

void stampaElencoPerPrezzo(prodotto elenco[], int dimensione, float prezzo){
	
	int i;
	for(i=0;i<dimensione;i++)
		if(elenco[i].prezzo>=prezzo){
			if(i!=0) printf("\n");
			stampa(elenco[i]);
		}		
}

bool isProdottoInScorta(prodotto p){
	return (p.giacenza>0 && p.giacenza<10);
}

bool isProdottoEsaurito(prodotto p){
	return p.giacenza==0;
}

bool isProdottoNuovo(prodotto p){
	return p.nuovo;
}

void stampaElencoProdottiInScorta(prodotto elenco[], int dimensione){
	int i;
	for(i=0;i<dimensione;i++)			
		if(isProdottoInScorta(elenco[i])){
				if(i!=0) printf("\n");
					stampa(elenco[i]);
		}
}

void stampaElencoProdottiEsauriti(prodotto elenco[], int dimensione){
	int i;
	for(i=0;i<dimensione;i++)			
		if(isProdottoEsaurito(elenco[i])){
				if(i!=0) printf("\n");
					stampa(elenco[i]);
		}
}

void stampaElencoOrdinatoPerReparto(prodotto elenco[], int dimensione){
	int i,j;
	for(i=Alimentari;i<=Abbigliamento;i++){	
		for(j=0;j<dimensione;j++)			
			if(elenco[j].collocazione==i){
				if(j!=0) printf("\n");
					stampa(elenco[j]);
			}
		printf("\n");	
	}
}

int cercaProdottoScontoMax(prodotto elenco[], int dimensione, reparto r){
	int pos=0;
	int i;
	for(i=1;i<dimensione;i++)
		if(elenco[i].collocazione==r && elenco[pos].sconto<elenco[i].sconto)
			pos=i;
	return pos;
}

void stampaElencoProdottoScontoMaxPerReparto(prodotto elenco[], int dimensione){
	int i,j;
	for(i=Alimentari;i<=Abbigliamento;i++){			
		if(i!=0) printf("\n");
			stampa(elenco[cercaProdottoScontoMax(elenco,dimensione,i)]);
	}
}


void stampaElencoProdottoNuovo(prodotto elenco[], int dimensione){
	int i;
	for(i=0;i<dimensione;i++)			
		if(isProdottoNuovo(elenco[i])){
				if(i!=0) printf("\n");
					stampa(elenco[i]);
		}
}
//restituisce l'elenco delle operazioni da cui scegliere
void stampaMenu(){
	printf("Scegli una delle seguenti operazioni da eseguire:");
	printf("\n1 - Elenco prodotti ordinato per reparto");
	printf("\n2 - Dettaglio dei prodotti che soddisfano la ricerca per prezzo (maggiore o uguale)");
	printf("\n3 - Elenco dei prodotti con sconto max per reparto");
	printf("\n4 - Elenco dei prodotti in scorta");
	printf("\n5 - Elenco dei prodotti esauriti di un certo reparto");
	printf("\n6 - Elenco dei nuovi prodotti");
	printf("\n7 - Elenco dei prodotti");
	printf("\n0 - Termina il programma");
}

int main(){
	
	prodotto lista[DIM] = {
		{Alimentari,1,"Prodotto 1","Descrizione prodotto 1",12.25,123,true,22},
		{Alimentari,2,"Prodotto 2","Descrizione prodotto 2",13.55,11,false,0},
		{Giocattoli,3,"Prodotto 3","Descrizione prodotto 3",12.35,2,false,35},
		{Edicola,4,"Prodotto 4","Descrizione prodotto 4",3.15,0,true,0},
		{Edicola,5,"Prodotto 5","Descrizione prodotto 5",7.00,45,false,0},
		{Giocattoli,6,"Prodotto 6","Descrizione prodotto 6",11.55,1,false,0},
		{Giocattoli,7,"Prodotto 7","Descrizione prodotto 7",2.85,0,false,43},
		{Alimentari,8,"Prodotto 8","Descrizione prodotto 8",11.00,0,true,0},
		{Edicola,9,"Prodotto 9","Descrizione prodotto 9",5.50,12,true,0},
		{Abbigliamento,10,"Prodotto 10","Descrizione prodotto 10",9.00,4,false,0}
	};
	
	int scelta;
	do{
		stampaMenu();
		printf("\n\nScelta: ");
		scanf("%d",&scelta);
						
		switch(scelta){
			case 0: printf("Programma terminato");break;
			case 1: printf("Elenco prodotti per reparto:\n");stampaElencoOrdinatoPerReparto(lista,DIM);break;
			case 2: {
				float ricerca; 
				printf("\nInserisci il prezzo: ");
				scanf("%f",&ricerca);
				printf("\nElenco prodotti trovati:\n");
				stampaElencoPerPrezzo(lista,DIM,ricerca);				
				break;
			}
			case 3: printf("Elenco prodotti con sconto max per reparto:\n");stampaElencoProdottoScontoMaxPerReparto(lista,DIM);break;
			case 4: printf("Elenco prodotti in scorta:\n");stampaElencoProdottiInScorta(lista,DIM);break;
			case 5: printf("Elenco prodotti esauriti nel reparto:\n");stampaElencoProdottiEsauriti(lista,DIM);break;
			case 6: printf("Elenco prodotti nuovi:\n");stampaElencoProdottoNuovo(lista,DIM);break;
			case 7: printf("Elenco prodotti:\n");stampaElenco(lista,DIM);break;
			default: printf("ERRORE! Valore inserito non valido!");
		}
		printf("\n\n");
	}while(scelta!=0);
	
}





