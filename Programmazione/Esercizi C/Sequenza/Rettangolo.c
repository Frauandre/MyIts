/*
Dati in input i lati di un rettagolo, calcolare
il perimetro, l'area e la diagonale
*/

#include <stdio.h>
#include <math.h>

int main(){
 
 //dichiarazione delle variabili      
//input
double ipotenusa; 
double angolo;



printf("inserisci ipotenusa:");
scanf("%lf",&ipotenusa); 

printf("inserisci angolo:");
scanf("%lf",&angolo);
 

//operazioni richieste
double cateto1=ipotenusa*sin(angolo*M_PI/180);
double cateto2=ipotenusa*cos(angolo*M_PI/180);
double perimetro=cateto1+cateto2+ipotenusa;
double area=(cateto1*cateto2)/2;

 
 //visualizzare i risultati ottenuti
 printf("\n cateto1: %lf " ,cateto1); 
  printf("\n cateto2: %lf " ,cateto2); 
 printf("\n perimetro: %lf " ,perimetro);
 printf("\n area: %lf " ,area);


 }
