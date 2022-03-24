/* 
testo:
switch case
*/

#include <stdio.h>
int main(){
	
int g;
printf ("inserisci il numero:");
scanf ("%d", &g);

switch(g){
case1: printf ("Lunedi");break //break serve per interrompere il flusso switch	
case2: printf ("Martedi");break
case3: printf ("Mercoledi");break
case4: printf ("Giovedi");break
case5: printf ("Venerdi");break
case6: printf ("Sabato");break
case7: printf ("Domenica");break
default: printf ("Errore"); //default è obbligatorio per evidenziare l'eventuale errore
	
}

}
