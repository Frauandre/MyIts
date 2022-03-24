#include <stdio.h>
#include <string.h>
#include <ctype.h>

#define LENGTH  30
#define MAX  5

void maiuscolo(char parola[],int dimensione){
	int i;
	for(i=0;i<dimensione;i++)
		printf("%c",toupper((int)parola[i]));
}

void minuscolo(char parola[],int dimensione){
	int i;
	for(i=0;i<dimensione;i++)
		printf("%c",tolower((int)parola[i]));
}

char *capitalize(char parola[], int dimensione){
	char *source=parola;
	
	source[0]=toupper((int)source[0]);
	
	int i;
	for(i=1;i<dimensione;i++)
		source[i]=tolower((int)source[i]);
		
	return source;
}


int main(){
    char nomi[MAX][LENGTH]={"pinucciO", "lucia","VIOLA","CarMEN","FrAnCesco"};
        
	printf("\n\nPascalCase:");
	int i;
	
	
	for(i=0;i<MAX;i++){
		printf("\nNominativo: %s, ",nomi[i]);
		printf(", PascalCase: %s",capitalize(nomi[i],strlen(nomi[i])));
	}    
    	     	
	   
}
   
