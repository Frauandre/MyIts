/*

Creare una matrice di numeri interi con dimensione generata casualmente 
e appartenente all'intervallo [10,50]. 
Il riempimento della matrice è casuale e tutti i numeri generati appartengono 
all'intervallo [inf,sup], con inf e sup inseriti da input.

Si richiedono le seguenti operazioni:

Stampare le somme orizzontali e verticali
Stampare le medie verticali e orizzontali

*/

#include <stdio.h>
#include <math.h>
#include <time.h>

int casuale(int sup, int inf){
	return rand()%(sup-1)+inf;	
}
int casuale2(int sup2, int inf2){
	return rand()%(sup2-1)+inf2;	
}
	
int main(){
	
	srand(time(NULL));
	
	int inf=10;
	int sup=50;
	int m(inf, sup);
	int n(inf, sup);
	
	int matrice[m][n];
	int sup2;
	int inf2;
	
	printf("\nInserisci sup: ");
	scanf("%d", &sup2);
	printf("\nInserisci inf: ");
	scanf("%d", &inf2);
	
	int i, j;
	for(i=0;i<m;i++){
	    for(j=0;j<n;j++)
	        printf("\t%d",matrice[i][j]);
        printf("\n");
}
	
}









