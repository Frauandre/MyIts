/*int numeroFacce = 6;
	int casuale = rand(); //genera un numero casuale
	int casuale2 = casuale%numeroFacce;
	int dado = casuale2+1;
	printf("lancio del dado: %d", dado);
	*/
	
	/*	SEQUENZA DADO
	int i;
	for(i=0;i<10;i++)
		printf("\nlancio del dado1: %d", lancioDado());
		printf("\nlancio del dado2: %d", lancioDado());
		printf("\nlancio del dado3: %d", lancioDado());
	*/
#include<stdio.h>
#include <math.h>
#include <time.h>

//funzione dado sei facce
int lancioDado(){
	return rand()%6+1;
}

int main(){
	int n;
	printf("quanti dadi vuoi tirare?:");
	scanf("%d", n);
	srand(time(NULL)); //mescolamento
	
	int conta1=0; conta2=0; conta3=0; conta4=0; conta5=0; conta6=0; //contatori
	int i=0;
	for(i=0;i<10;i++)
					 switch(lancioDado()){
					 	case1:conta1++;break;
					 	case2:conta2++;break;
					 	case3:conta3++;break;
					 	case4:conta4++;break;
					 	case5:conta5++;break;
					 	case6:conta6++;break;
					 }
		printf("\n1: %d", conta1);
		printf("\n2: %d", conta2);
		printf("\n3: %d", conta3);
		printf("\n4: %d", conta4);
		printf("\n5: %d", conta5);
		printf("\n6: %d", conta6);
		
		printf("\n1: %.2f", (float)conta1/n*100);
		printf("\n2: %.2f", (float)conta2/n*100);
        printf("\n3: %.2f", (float)conta3/n*100);
		printf("\n4: %.2f", (float)conta4/n*100);
		printf("\n5: %.2f", (float)conta5/n*100);
		printf("\n6: %.2f", (float)conta6/n*100);

}
