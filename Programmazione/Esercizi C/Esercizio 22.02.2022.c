/*
	Salvare su file di testo le date con format letterale append
	in input inserite i dati in forma numerica
	usare le strutture di dati, i puntatori, le funzioni
*/
#include <stdio.h>
#include <string.h>

typedef struct {
	int giorno;
	int mese;
	int anno;
}data;

void formatDataLineare(data *unaData){
	
	printf("%d/%d/%d",oggi->giorno,oggi->mese,oggi->anno);
}

int main(){
	
	data oGGi={22,2,2022};
	
	formatDataLineare(&oGGi);
	
}
