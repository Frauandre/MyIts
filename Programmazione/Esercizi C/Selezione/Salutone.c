/*
Dato in input l'ora, restituire il messaggio di saluto
(buongiorno, buon pomeriggio, buona sera, buona notte)
in caso di errore segnalarlo
*/
#include<stdio.h>

int main(){

//dichiarazione delle variabili
int h;
printf("inserisci ora:");
scanf("%d",&h);
if(h<0)
  printf("errore");
else if(h>23)
  printf("errore");
else if (h<6)
   printf("Buona notte");
   else if(h<14)
   printf("Buon giorno");
   else if(h<18)
   printf("Buon pomeriggio");
   else if(h<22)
   printf("Buona sera");
   else
   printf("Buona notte");

}
