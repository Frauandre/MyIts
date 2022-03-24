/*
Dati in input i lati di un rettagolo, calcolare
il perimetro, l'area e la diagonale
*/

#include <stdio.h>
#include <math.h>
int main(){
 
 //dichiarazione delle variabili      
//input
double lato1; 
double lato2;


printf("inserisci il lato1:");
scanf("%lf",lato1); 

printf("inserisci il lato2:");
scanf("%lf",lato2); 

//operazioni richieste
double perimetro=(lato1*2)+(lato2*2);
double area=lato1*lato2;
double diagonale=sqrt(lato1*2+lato2*2);
 
 
 //visualizzare i risultati ottenuti
 printf("\n perimetro: %.2f " ,perimetro); 
 printf("\n area: %.2f " ,area);
 printf("\n diagonale: %.2f " ,diagonale);

 }
