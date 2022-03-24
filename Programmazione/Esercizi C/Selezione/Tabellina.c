/*
Stampare la tabellina di un certo numero intero dato in input
*/


#include<stdio.h>
int main(){
	
	int n;
		printf("inserisci un numero intero positivo:");
		scanf("%d",&n);
		if(n<0)
  			   printf("\nERRORE NUMERO NON POSITIVO\n\n");
		int i;
		for(i=1;i<=10;i++)
			 printf("\t%d", n*i);
	
	
}
