//totale, sconto e totale scontato
// costo 10, 30% di sconto, prendo 3 pezzi
#include <stdio.h>
int main(){
 
 //dichiarazione delle variabili      
//input
float prezzo; //prezzo
int quantita; //quantità
int percentualeSconto;


printf("inserisci il prezzo:");
scanf("%f",&prezzo); 

 printf("inserisci la quantita':");
scanf("%d",&quantita);
 
printf("inserisci la percentuale di sconto:");
scanf("%d",&percentualeSconto);  

//operazioni richieste
float tot = prezzo*quantita;
float sconto= (float)tot*percentualeSconto/100;
float totaleScontato= tot-sconto;
 
 
 //visualizzare i risultati ottenuti
 printf("\nrisultato totale: %.2f euro" ,sconto); //%.2f = due cifre dopo la virgola
 printf("\totaleScontato: %.2f euro" ,totaleScontato);
 }
