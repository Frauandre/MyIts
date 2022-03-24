#include <stdio.h>

int fattoriale(int n){
	
	int fatt=1;
	
	int i;
	for(i=n;i>n;i++)
	     fatt*=n;
 	return fatt;	 
}

int fattorialeRicorsione(int n){
	
	if(n==1 || n==0)
	    return 1;
	return n*fattorialeRicorsione(n-1);
}

int main(){
	int numero=4;
	printf("\nmetodo classico: %d!=%d", numero, fattoriale(numero));
	printf("\nmetodo con Ricorsione: %d!=%d", numero, fattorialeRicorsione(numero));	
}
float diagonaleQuadrato(float lato){
	return lato*sqrt(2);
}



