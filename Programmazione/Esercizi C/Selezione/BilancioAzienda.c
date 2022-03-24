/*

Calcolare il totale del fatturato e delle spese sostenute da un'azienda.
Di ogni consulente si conosce il fatturato e le spese sostenute.
Si richiede inoltre di visualizzare il fatturato max, le spese minime, qual'è 
il guadagno massimo 

*/
#include <stdio.h>
#include <math.h>
#include <float.h>

int main(){
	
	int n;
	printf("Quanti consulenti ha l'azienda?: ");
	scanf("%d",&n);
	
	float totaleFatturato=0;
	float totaleSpese=0;
	float fatturatoMax=FLT_MIN;
	float speseMin=FLT_MAX;
	float guadagnoMax=FLT_MIN;
	
	float fatturato;
	float spese;
	
	int i;
	for(i=0;i<n;i++){
		printf("Fatturato consulente: ");
		scanf("%f", &fatturato);
		
		printf("Spese consulente: ");
		scanf("%f", &spese);
		
		//operazioni
		totaleFatturato += fatturato;
		totaleSpese += spese;
		
		if(fatturatoMax<fatturato){
		fatturatoMax=fatturato;
	}
			if(speseMin<spese){
		speseMin=spese;
	}
			if(guadagnoMax<fatturato-spese){
		guadagnoMax=fatturato-spese;
	}
		//stampe
		printf("Risultati: ");
		printf("\nFatturato azienda: %.2f", totaleFatturato);
		printf("\nSpese azienda: %.2f", totaleSpese);
		printf("\nFatturato massimo: %.2f", fatturatoMax);
		printf("\nSpese minime: %.2f", speseMin);
		printf("\nGuadagno massimo: %.2f", guadagnoMax);
		
	}
	
		
}
