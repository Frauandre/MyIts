/* 
testo:
switch case
*/

#include <stdio.h>
int main(){
	
int g;
printf ("inserisci il numero:");
scanf ("%d", &g);

if (g<0 || g==0)
printf ("Errore");
else if (g==1)
printf ("Lunedi");
else if (g==2)
printf ("Martedi");
else if (g==3)
printf ("Mercoledi");
else if (g==4)
printf ("Giovedi");
else if (g==5)
printf ("Venerdi");
else if (g==6)
printf ("Sabato");
else if (g==7)
printf ("Domenica");
else if (g>7)
printf ("Errore");

}
