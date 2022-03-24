/*
Creare una funzione per incrementare il valore di una variabile

es. 
prima
x=10

dopo
x=11
*/

#include <stdio.h>

void incremento(int *n){
	*n=*n+1;
}

int main(){
	
	//scanf("%d",&n);
	
	int x=10;
	printf("\nprima: %d",x);
	incremento(&x);
	printf("\n\ndopo: %d",x);	
}
