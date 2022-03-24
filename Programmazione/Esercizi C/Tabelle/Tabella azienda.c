/*
Una azienda ha 15 consulenti di cui si conosce il nominativo,
il fatturato lordo, le spese sostenute

Si richiede di stampare il totale del fatturato lordo, il totale delle spese sostenute,
il nominativo del consulente col fatturato massimo
il nominativo del consulente con spese minime

costruire un menu testuale per effettuare le varie richieste
*/

#include <stdio.h>
#include <string.h>
#define LENGHT 15

typedef struct{
	char nominativo[50];
	float fatturatoLordo;
	float spesaTotale;
}azienda;

void stampa(azienda a){
	printf("\n Nominativo: %s",a.nominativo);
	printf("\n Fatturato lordo: %lf",a.fatturatoLordo);
	printf("\n Spese sostenute: %lf",a.spesaTotale);
	}

int main(){
	
	azienda a[LENGHT] = {
	{"Mino Raiola", 4000.00, 2000.00},
	{"Elio Scalia", 5000.00, 2500.00},
	{"Antonio Cassano", 4550.00, 2250.00},
	{"Dario Moccia", 7000.00, 2500.00},
	{"Giuseppe Verdi", 3000.00, 1500.00},
	{"Mario Rossi", 4000.00, 1250.00},
	{"Luca Bianchi", 4000.00, 1800.00},
	{"Ercole Neri", 4000.00, 1000.00},
	{"Antonio Mais", 4000.00, 2800.00},
	{"Alessio Anselmo", 4000.00, 600.00},
	{"Edoardo Data", 4000.00, 2100.00},
	{"Andrea Frau", 4000.00, 1900.00},
	{"Matteo Drago", 4000.00, 2000.00},
	{"Alessandro Manzoni", 4000.00, 3000.00},
	{"Sigmund Freud", 4000.00, 2950.00},};

  int i;
	printf ("\n Consulenti: ");
	for (i=0;i<LENGHT;i++){
		printf ("\n\n");
	stampa(a[i]);
		
}

float sommaFatturato=0;
for(i=0;i<LENGHT;i++){
		sommaFatturato+-a[i].fatturatoLordo;
	}
	
printf("\n\nTotale Fatturato: %lf ", sommaFatturato);

}


