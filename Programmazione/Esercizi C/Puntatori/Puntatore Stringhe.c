#include <stdio.h>

int main(){

char *p;

printf("\nInserisci un nome: ");
scanf("%s", &p);

printf("\nNome: %s, lunghezza: %d", p, strlen(p));

}
