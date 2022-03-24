/*Generare un array di numeri casuali appartenenti ad un intrvallo(inf; sup),
con inf e sup dati da input, la dimensione dell'array e genera dinamicamente 
e appartiene all'intervallo (1,100).
Inserire un numero sentinella da ricercare nell' array.
Restituire la posizione della prima occorenza utile oppure la stringa "numero
non trovato".
*/
#include <stdio.h>
#include <math.h>
#include <time.h>

int casuale(int inf, int sup){
	return rand()%(sup-inf+1)+inf;
}

void stampaArray(int v[], int dimensione){
	int i;
	for(i=0;i<dimensione;i++)
 	  printf("\n[%d]: %d",i,v[i]);
}

int indexOf(int v[], dimensione, int elemento){
	
	int i;
	for(i=0;i<dimensione;i++)
	  if v[i]==elemento
	  	 return i;
	  return -1;
}

int main(){
	srand(time(NULL));
	
	int inf=1;
	int sup=100;
	
	//dichiarazione di un array di numeri interi
	int dimesione=casuale(inf,sup);
	int numeri[dimensione];
	
	printf("inf: ");
	scanf("%d",&inf);
	
	printf("sup: ");
	scanf("%d",&sup);
	
	int i;
	for(i=0;i<dimensione;i++)
	   numeri[i]=casuale(inf, sup);
	   
    int numero;
    printf("inserisci un numero da ricercare: ");
    scanf("%d",&numero);
    
    int pos=indexOf(numeri, dimensione, numero);
    printf("\n\n");
    
    int pos=-1; //non ho trovato nessun numero
   	for(i=0;i<dimensione;i++)
   	    if(numeri[i]==numero){
   	        pos=1;
   	        break;
   	    }
   	    
   	printf("\n\n");
	       
   	    if (pos==-1)
   	        printf("numero non trovato");
        else
            printf("%d trovato in posizione: %d",numero, pos); 
}
