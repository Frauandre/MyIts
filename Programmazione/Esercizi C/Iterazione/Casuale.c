#include<stdio.h>
#include <math.h>
#include <time.h>

int main(){
	
	srand(time(NULL)); //mescolamento
	int casuale = rand(); //genera un numero casuale
	printf("casuale: %d", casuale);
}
