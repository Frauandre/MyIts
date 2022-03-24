/*
	Data una frase preconfezionata, stampare la frase in output
	
	NB:Usare i puntatori
*/
#include <stdio.h>

int main(){
	
	char frase[30]="Oggi e' il 22 Febbraio 2022";
	
	char *p="Oggi e' il 22 Febbraio 2022";
	
	printf("%s", frase);
	printf("\n%s", p);
}
