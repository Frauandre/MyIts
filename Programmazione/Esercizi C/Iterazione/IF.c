/*
Dato in input due numerio interi, visualizzarli in ordine crescente

*/
#include<stdio.h>

int main(){

//dichiarazione delle variabili
int n1;
printf("inserisci un numero intero:");
scanf("%d",&n1);

int n2;
printf("inserisci un numero intero:");
scanf("%d",&n2);

//test
//if //else
if(n1>n2)
printf("\n %d %d, n2, n1",n1);
else
printf("\n %d %d, n1, n2",n2);
}
