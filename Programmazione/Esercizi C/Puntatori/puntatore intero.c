#include <stdio.h>

int main(){

int n=12;

int *p=&n;//varabile puntatore = memorizza indirizzo di memoria

printf("variabile n: %d, indirizzo di memoria: %d",n,&n);
printf("variabile puntatore: %d, indirizzo di memoria: %d", *p,&p);

}
