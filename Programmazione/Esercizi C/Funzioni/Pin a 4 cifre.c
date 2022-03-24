/*

Stampa un pin a 4 cifre

*/
#include <math.h>
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
int main(){
	int n=4;
	int i;
	for(i=0;i<n;i++){
		int a= rand()%10;
		printf("%d",a);
	}
	
}

/*
#include <math.h>
#include <time.h>
#include <stdio.h>

int genera(){
     return rand()%10;
 }
 
 int main(){
 
    srand(time(NULL));
    
    printf("Generazione di un pin numerico a 4 cifre");
    
    printf("\n\n");
    printf("PIN: ");
    int i;
    for (i=0;i<4;i++)
         printf("%d", genera());



*/
