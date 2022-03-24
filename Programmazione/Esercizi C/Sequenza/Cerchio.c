/*
Dati in input i lati di un rettagolo, calcolare
il perimetro, l'area e la diagonale
*/

#include <stdio.h>
#include <math.h>

int main(){
 
 //dichiarazione delle variabili      
//input
double base; 
double altezza;



printf("inserisci la base: ");
scanf("%lf",&base); 

printf("inserisci altezza: ");
scanf("%lf",&altezza);
 

//operazioni richieste
double perimetro=(base+base)+(altezza+altezza);
double area=base*altezza;
double diagonale=sqrt(pow(base,2)+pow(altezza,2));

 
 //visualizzare i risultati ottenuti
 printf("\n perimetro: %lf cm " ,perimetro); 
 printf("\n area: %lf cm " ,area);
 printf("\n diagonale: %lf cm " ,diagonale);
}
