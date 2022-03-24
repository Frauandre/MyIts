/*
	Uso della funzione sizeof
*/
#include <stdio.h>

typedef struct {
	int giorno;
	int mese;
	int anno;
}data;

int main(){

	//dichiarazione delle variabili
	short a=12;
	int n=123;
	float f=12.35;
	double d=12.89567;
	
	char c='c';
	
	int numeri[5]={12,23,34,45,56};
	char frase[30]="Oggi e' il 22 Febbraio 2022";
	char nomi[5][30]={"Luigi","Matteo","Virginia","Antonella","Sabrina"};
	
	printf("SIZEOF");
	print("\n sizeof(short): %d",sizeof(a));
	print("\n sizeof(int): %d",sizeof(n));
	print("\n sizeof(float): %d",sizeof(f));
	print("\n sizeof(double): %d",sizeof(d));
	
	print("\n sizeof(char): %d",sizeof(c));
	
	print("\n sizeof(array int): %d",sizeof(numeri));
	print("\n sizeof(array char): %d",sizeof(frase));
	print("\n sizeof(array di stringhe): %d",sizeof(nomi));
	print("\n sizeof(struttura): %d",sizeof(oggi));
	
	print("\n dimensione con sizeof(array di stringhe): %d",sizeof(nomi)/sizeof(nomi[0]));
	print("\n dimensione con sizeof(array int): %d",sizeof(numeri)/sizeof(numeri[0]));
}
