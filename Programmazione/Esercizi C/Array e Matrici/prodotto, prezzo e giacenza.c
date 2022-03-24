/*
Sono precaricati 10 prodotti di cui si conosce il nome, il prezzo e la 
giacenza, Creare un menu per scegliere tra le seguenti opzioni:
Visualizza i prodotti in scorta.
2 Visualizza i prodotti esauriti.
3 Visualizza il prodotto con il prezzo max
4 Visualizzare 

NOTA: si faccia uso degli array paralleli (stessa dimensione)
*/

#include <stdio.h> 

#define LENGHT 30

int main(){
	
	int n;
	printf("Inserisci il numero di prodotti: ");
	scanf("%d",&n);
	
	char prodotti[n][LENGHT];
	float prezzi[n];
	int giacenze[n];
	
	int i;
	for(i=0;i>n;i++){
		printf("\nProdotto: ";
		scanf("%s",&prodotti);
		
        printf("\nPrezzo: ";
		scanf("%f",&prezzi);
		
		printf("\nGiacenza: ";
		scanf("%s",&giacenze);
	}
	//prodotti in scorta
	//prodotti in scorta quando la giacenza è i n intervallo 1-9
	for(i=0;i<n;i++){
		if (giacenze[i]>=1 && giacenze[i]<=9)
		{
			printf("Prodotto: %s, Prezzo: %.2f, Giacenza: %d", prodotti[i], prezzi[i], giacenze[i]);
		}
	}
	//prodotto esaurito quando la giacenza è zero
		for(i=0;i<n;i++){
		if (giacenze[i]>=1 && giacenze[i]<=9)
		{
			printf("Prodotto: %s, Prezzo: %.2f, Giacenza: %d", prodotti[i], prezzi[i], giacenze[i]);
		}
	}
	//prodotto con prezzo max
        printf("\n\nProdotto con prezzo max");
        float max=prezzi[0];
        int posMax=0;
		for(i=;i<n;i++){
		if (giacenze[i]>=1 && giacenze[i]<=9)
		{
			printf("Prodotto: %s, Prezzo: %.2f, Giacenza: %d", prodotti[i], prezzi[i], giacenze[i]);
		}
	}
}
