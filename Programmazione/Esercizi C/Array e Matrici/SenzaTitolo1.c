/*
TESTO:
Dato in input il lato di un quadrato, calcolare il perimetro, l'area e la diagonale
Visualizzare i risultati
*/

#include <stdio.h>
#include <math.h> //libreria funzioni matematiche

int main(){
 
 //dichiarazione delle variabili      
//input
double lato; 

printf("inserisci il lato:");
scanf("%lf",&lato); 

 

//operazioni richieste
double perimetro = lato*4;
double area = lato*lato;
double diagonale = lato*sqrt(2); //sqrt(double x)= radice quadrata di x 
 
 
 //visualizzare i risultati ottenuti
 printf("\nperimetro:%lf" ,perimetro); 
 printf("\narea:%lf" ,area);
 printf("\ndiagonale:%lf" ,diagonale);
 }
