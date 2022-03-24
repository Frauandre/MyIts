/*
	Data una frase preconfezionata, stampare la frase in output
	
	NB:Usare i puntatori
*/
#include <stdio.h>

typedef struct {
	int giorno;
	int mese;
	int anno;
}data;

void formatDataLineare(data *oggi){
	
	printf("%d/%d/%d",oggi->giorno,oggi->mese,oggi->anno);
}

int main(){
	
	data oGGi={22,2,2022};
	
	formatDataLineare(&oGGi);
	
}
