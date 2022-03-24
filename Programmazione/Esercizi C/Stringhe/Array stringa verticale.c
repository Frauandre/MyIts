#include <stdio.h>

int main(){

	char stringa[15];
	
	printf("inserisci una frase: ");
	scanf("%s",&stringa);
	
	int i;
	for(i=0;i<15;i++)
         if (stringa[i]=='\0')
             break;
	     else
	printf("\n%c",stringa[i]);

}
