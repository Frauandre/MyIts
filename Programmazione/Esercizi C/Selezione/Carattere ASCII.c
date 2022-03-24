#include <stdio.h>
/*
dato in input un carattere
visualizzare il suo codice numerico su alfabeto ASCII

*/
int main(){
char carattere= 'c';//variabile che srve per i caratteri da tastiera	
	printf("inserisci un carattere:");
	scanf("%c",&carattere);
	
	int posizione = (int)carattere;//posizione del carattere in alfabeto ASCII

printf("/n carattere:%c", carattere);//%c si usa per i caratteri
printf("/n posizione ASCII:%d", carattere);



 }
