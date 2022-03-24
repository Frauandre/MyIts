/*
Dati i lati di un triangolo, visualizzare se è di tipo equilatero, isoscele 
o scaleno.
*/
#include<stdio.h>
int main(){
	double l1, l2, l3;
	printf("inserisci lato1=");
	scanf("%lf",&l1);
	
		printf("inserisci lato2=");
	scanf("%lf",&l2);
	
		printf("inserisci lato3=");
	scanf("%lf",&l3);
	
if(l1==l2 && l1==l3)
   printf("Triangolo equilatero");
	else if(l1==l2 || l1==l3 || l2==l3)
	printf("Triangolo isoscele");
	else
	printf("Triangolo scaleno");
		
}
