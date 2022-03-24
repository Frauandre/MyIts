/*
TIPO ENUM

tipo semaforo(rosso, verde, giallo)
tipo boolean (false, true)
tipo giorniSetttimana(Lun, Mar....)


enum semaforo{VERDE, GIALLO, ROSSO};
enum boolean {FALSE; TRUE};
enum giorniSettimana{LUN, MAR, MER, GIO, VEN, SAB, DOM};

int main(){
	
	int i
	for(i=LUN;i<=DOM;i++)
        printf("%d\n", i); 
}
Creare una funzione per incrementare il valore di una variabile

es. x=10;
dopo
x=11;
*/
#include<stdio.h>
#include <math.h>

void incremento(int *n){
	*n=*n+1;
}

int main(){
	//un puntatore è una variabile che punta alla memoria di un altra variabile
	
	int x=10;
	printf("\nprima: %d", x);
	incremento(&x);//poi va richiamata la memoria come se fosse uno scanf&
	printf("\ndopo: %d", x);
	
}

