/*
	Data in input una sequenza oraria in secondi
	Stampare soltanto il seguente format: hh:mm:ss
	Usare i puntatori e il passaggio di parametri by reference
*/
#include <stdio.h>

void calcolaSequenzaOraria(int tempoInSecondi,int *ore,int *minuti,int *secondi);

int main(){
	int tempo;
	printf("Inserisci il tempo della sequenza oraria in secondi: ");
	scanf("%d",&tempo);
	
	int h,m,s;
	
	calcolaSequenzaOraria(tempo,&h,&m,&s);
	
	printf("%d:%d:%d",h,m,s);
}

void calcolaSequenzaOraria (int tempoInSecondi,int *ore,int *minuti,int *secondi){
	*ore=tempoInSecondi/3600; //calcolo le ore
	*minuti=(tempoInSecondi%3600)/60; //calcolo i minuti
	*secondi=(tempoInSecondi%3600)%60; //calcolo i secondi
}
