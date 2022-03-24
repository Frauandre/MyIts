/*
Generare una password casuale con lunghezza predefinita in input
*/
#include <stdio.h>
#include <math.h>
#include <time.h>

	
	
	
	
int casuale(int inf, int sup){
     return rand()%((sup-inf+1)+inf);
 }
 
 int main(){
 	
 	/*printf("Nomi in elenco");
 	
 	char nomi[5][20]={"Pino", "Gino", "Gina", "Rina", "Tina"};
 	*/
 
    srand(time(NULL));
    
    printf("Generazione di una password casuale");
    
    int n;
    printf("\nInserisci la lunghezza della password: ");
    scanf("%d",&n);
    
    char pattern[1][62] = {"ABCDEFGHIJKLMNPPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"};
    
    
    printf("\n\n");
    printf("Password: ");
    int i;
    for (i=0;i<n;i++)
         printf("%c", pattern[0][casuale(0,61)]);

}
	
	

