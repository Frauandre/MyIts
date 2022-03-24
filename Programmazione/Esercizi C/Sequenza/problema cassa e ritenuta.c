/*
azienda
Dato in input, calcolare iva e il totale da pagare.
Visualizzare i risultati
*/

#include <stdio.h>
#define ALTIQUOTAIVA 22
int main(){
 
 //dichiarazione delle variabili      
//input
float costo; 

printf("inserisci il costo:");
scanf("%f",&costo); 

 

//operazioni richieste
float percentualeCassa = 4;
float cassaPrevidenziale = (costo*percentualeCassa)/100;
float imponibile = costo+cassaPrevidenziale;
float percentualeDacconto = 20;
float ritenutaDacconto = (imponibile*percentualeDacconto)/100;
float nettoaPagare = imponibile+ALTIQUOTAIVA+ritenutaDacconto;

 
 
 //visualizzare i risultati ottenuti
 printf("\n costo: %.2f euro" ,costo); 
 printf("\n cassaPrevidenziale: %.2f euro" ,cassaPrevidenziale);
 printf("\n imponibile: %.2f euro" ,imponibile);
 printf("\n ritenutaDacconto: %.2f euro" ,ritenutaDacconto);
 printf("\n nettoaPagare: %.2f euro" ,nettoaPagare);
 }
