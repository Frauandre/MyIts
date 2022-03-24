/*

Stampa un pin a 4 cifre

*/
#include <math.h>
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
int main(){
	int numero;
	int i;
	for(i=0;i<4;i++){
		int a= rand()%10;
		printf("%d",a);
	}
	
}
