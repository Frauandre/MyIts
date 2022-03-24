#include <stdio.h>

int main(){

int numeri[5]={12, -4, 7, -9, -8};

int *p=&numeri;//varabile puntatore = memorizza indirizzo di memoria

int i;
for (i=0;i<5;i++){
printf("%d, indirizzo di memoria: %d",numeri[i],&numeri[i]);
printf("\npuntatore *p, %d, indirizzo di memoria: %d", *p,&p);

p++
}

}
