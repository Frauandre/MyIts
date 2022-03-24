/*
Dato in input un numero intero positivo,
stampare la matrice triangolare inferiore di numeri crescenti
*/


#include<stdio.h>
int main(){
	
	int n;
		printf("inserisci un numero intero positivo:");
		scanf("%d",&n);
		
	int i, j, k;
	//output 1
	for(i=0;i<=n;i++){
		
		for(j=1;j<n-i;j++);
		printf("%d",j);
	printf("\n");
	}
	
	printf("\n\n");
	
	//output 2
	
	for(i=0;i<=n;i++){
		for(k=0;k<i;k++);
		printf(" ");
		for(j=1;j<n-i;j++);
		printf("%d",j);
	printf("\n");
	}
	
	//output 3
	
for(i=1;i<n;i++){
		for(k=0;k<n-i;k++);
		printf(" ");
		for(j=1;j<=i;j++);
		printf("%d" ,j);
	printf("\n");
	}	
}
