/*
Calcolare il fattoriale di un numero naturale,
dato in input

es. n=4; 4!= 4*3*2*1

eccezioni
0!=1
1!=1
*/


#include<stdio.h>
int main(){
	int n;
	
	do{
		printf("inserisci un numero naturale:");
		scanf("%d",&n);
		
		if(n<0)
		printf("\nERRORE\n\n");
	}while(n<0)
			   int i, fattoriale=1;
			   for(i=n;i>1;i--)
			      fattoriale *=i;
	printf("\n%d!=%d",n, fattoriale);
	
	
}
