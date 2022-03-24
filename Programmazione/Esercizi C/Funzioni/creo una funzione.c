/*

Creo una funzione

somma

definire una funzione

tipo identificatore(parametri){}
*/
#include <stdio.h>
int somma(int x, int y){ //variabile locale
	int s = x+y;
	return s;
}
int sottrazione(int x, int y){ //variabile locale
	int s = x-y;
	return s;
}

int main(){
	
	int a = 12;
	int b = 21;
	
	int s = sottrazione(a,b);
	
		printf("%d-%d=%d",a, b, s);
}

