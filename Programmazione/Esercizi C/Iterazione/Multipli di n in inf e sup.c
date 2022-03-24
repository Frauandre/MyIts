/* 
testo:
stampa i numeri interi multipli di N appartenenti all'intervallo [inf,sup]
*/

#include <stdio.h>
int main(){
	
int inf,sup, n;
printf("inf:");
scanf("%d",&inf);

printf("sup:");
scanf("%d",&sup);

printf("Multipli di quale valore:");
scanf("%d",&n);

while(inf<=sup){
	if(inf%n==0)
   printf("\t%d", inf);	
   inf++; 
}
  

}
