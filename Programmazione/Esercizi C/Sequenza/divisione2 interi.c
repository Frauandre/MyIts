 #include <stdio.h> 
/*

area di commento

Testo del problema
Dati in input due numeri interi, calcolare il quoziente intero, il resto, e il quoziente reale
Visualizzare i risultati
*/ 
 int main(){
 
 //dichiarazione delle variabili      
//input
int a;//dividendo
int b;//divisore

printf("inserisci il dividendo:");
scanf("%d",&a); //comando di input da tastiera, indicare decimale e variabile, con % e & (%d=decimale)

 printf("inserisci il divisore:");
scanf("%d",&b);   //&b NON va tra virgolette

//operazioni richieste
int q = a/b;
 int r = a%b; //% serve per il resto della divisione
 float qr= (float)a/b; //variabile per numeri reali float (double) //(float)operazione casting
 
 //visualizzare i risultati ottenuti
 printf("\nquoziente intero: %d" ,q); // \n serve per far andare il testo a capo
 printf("\nresto: %d" ,r);
 printf("\nquoziente reale: %f" ,qr); //%f si usa solo nei numeri float
 
 //errori, arancione=warning, qualcosa non funzionerà
 //errori, rosso=sbagliato
 
}

//il prezzo e la quantità del prodotto, calcolare il totale e visualizzare il risultato
