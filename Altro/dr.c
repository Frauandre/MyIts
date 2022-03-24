/*
Alla fine di un concorso vengono pubblicati i risultati delle prove dei concorrenti:
 vengono memorizzati, per ogni partecipante, il nominativo, il numero della pettorina,
 la data di nascita, il punteggio della prima prova, il punteggio della seconda prova. 

Si vuole ottenere:

1. l'elenco dei concorrenti partecipanti con nominativo, numero pettorina, data di nascita ed età
2. la graduatoria parziale rispetto alla prima prova
3. la graduatoria parziale rispetto alla seconda prova
4. la graduatoria finale rispetto al punteggio del totale conseguito
5. Si utilizzi un menu che consenta la scelta dell'operazione da eseguire. 

Si consideri una tabella pre-caricata con almeno 15 concorrenti.
*/

#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#define LENGTH 15

typedef struct{
	int giorno;
	int mese;
	int anno; 
}data;

typedef struct {
	char nominativo[30];
	int numeroPettorina;
	int primaProva;
	int secondaProva;
	data dataNascita;
}partecipante;

void stampaDettaglio(partecipante p){
	printf("\n Nominativo: %s",p.nominativo);
	printf("\n NumeroPettorina: %d",p.numeroPettorina);
	printf("\n primaProva: %d",p.primaProva);
	printf("\n secondaProva': %d",p.secondaProva);
}

void formatDataLetterale(data unaData){
	
	char mesi[12][9]={"Gennaio","Febbraio","Marzo","Aprile","Maggio","Giugno","Luglio"
		,"Agosto","Settembre","Ottobre","Novembre","Dicembre"};
		
	printf("%d %s %d",unaData.giorno,mesi[unaData.mese-1],unaData.anno);
}



int calcoloEta(data unaData){
	data oggi;
	oggi.anno=2022;
	oggi.mese=1;
	oggi.giorno=18;
	
	int eta = oggi.anno-unaData.anno;
	
	if((unaData.mese>oggi.mese) || (unaData.mese==oggi.mese && unaData.giorno>oggi.giorno))
		eta--;
		
	return eta;
}

//prima graduatoria
void scambio(int *x,int *y){
	int tmp=*x;
	*x=*y;
	*y=tmp;
}

int primaGrad (partecipante p[]){
	int j,i; //i 
	for(i=0;i<LENGTH-1;i++)
	for(j=i+1;j<LENGTH;j++)
	if(p[i].primaProva<p[j].primaProva){
		
		scambio(&p[i].primaProva,&p[j].primaProva);
	}
	for(i=0;i<LENGTH;i++){
	printf("\n %d ",p[i].primaProva);
	printf("\n %s ",p[i].nominativo);}
	
}

int test (partecipante p[]){
	
}




int main(){
	
	//inserisco dati partecipante
	partecipante p[LENGTH]={
	{"AlbertoArbusto",12,80,90},
	{"Nominato2",13,70,70},
	{"Nominato3",8,100,30},
	{"Nominato4",7,40,70},
	{"Nominato5",9,60,35},
	{"Nominato6",14,30,21},
	{"Nominato7",11,10,38},
	{"Nominato8",10,50,20},
	{"Nominato9",6,45,59},
	{"Nominato10",5,86,77},
	{"Nominato11",4,67,95},
	{"Nominato12",3,45,24},
	{"Nominato13",2,70,100},
	{"Nominato14",1,12,56},
	{"Nominato15",15,70,76},
	};
	
	data d[LENGTH]={
		{12,12,2000},
		{20,11,1986},
		{21,2,199},
		{22,1,2000},
		{23,8,2001},
		{24,3,2003},
		{25,8,2001},
		{1,1,1998},
		{1,8,1997},
		{2,3,1987},
		{3,1,1996},
		{4,4,2001},
		{5,5,2002},
		{6,6,2004},
		{7,11,2003},
	};
	
	//menu
	int numero;
	
do{
	printf("\n\n1 elenco dei concorrenti partecipantin: \n2  graduatoria parziale rispetto alla prima prova: \n3  graduatoria parziale rispetto alla seconda prova: \n4  graduatoria parziale rispetto alla prova totale \n0 per uscire\n");
	scanf("%d",&numero);
	switch (numero){
		case 1:{
			//stampa 1.
		int i;
		for (i=0;i<LENGTH;i++){
			printf ("\n");
			stampaDettaglio(p[i]);
			printf ("\n data nascita: ");
			formatDataLetterale(d[i]);
			printf ("\n age: %d",calcoloEta(d[i]));
			}break;
		}
		
		case 2:{
			primaGrad(p);
			
			break;
		}
		
		case 3:{
			break;
		}
		case 4:{
			break;
		}
		case 0:break;
		default:printf("dati inseriti non validi\n");break;
		
	}	
	
	}while (numero !=0);
	printf ("\n Bye bye");
		
		
			
	
				
	
	
	
}
