/*
TESTO:
calcolare la media et� di 3 persone
Visualizzare i risultati
*/

#include <stdio.h>
#include <math.h> //libreria funzioni matematiche

int main(){
 
//dichiarazione delle variabili      

int primo;// et� prima persona
int secondo;// et� seconda persona
int terzo; //et� terza persona

printf("inserisci la prima eta:");
scanf("%d",&primo);

printf("inserisci la seconda eta:");
scanf("%d",&secondo);

printf("inserisci la terza eta:");
scanf("%d",&terzo);  

//operazioni richieste
int somma = primo+secondo+terzo;
double media = (double)somma/3;

 
 
 //visualizzare i risultati ottenuti
 printf("\nmedia:%1f" ,media);

 }
