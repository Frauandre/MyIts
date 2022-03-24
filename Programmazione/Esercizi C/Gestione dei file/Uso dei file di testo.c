/*
	Uso dei file di testo
*/

//accesso al file di testo
//scrittura
//lettura
// accesso al file

#include <stdio.h>

int main(){
	
	char frase[30]= "Oggi e' il 22 Febbraio 2022";
	
	//variabile puntatore che individuerà i file di testo
	FILE *file;
	
	//accesso al file in mod scrittura
	file=fopen("testo.txt","w");
	
	//codifica del file con l'aggiunta del contenuto della variabile frase
	fwrite(frase,sizeof(frase),1,file);
	
	//salva tutto e termina. Rilascia la risorsa
	fclose(file);
	
	printf("Operazione eseguita correttamente");
}
