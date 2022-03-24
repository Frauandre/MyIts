/* 
testo:
stampa numeri interi appartenenti all'intervallo [inf,sup]
*/

#include <stdio.h>
int main(){
	
int inf,sup;
printf("inf:");
scanf("%d",&inf);

printf("sup:");
scanf("%d",&sup);

while(inf<=sup){
   printf("\t%d", inf);	
   inf++; 
}
  

}
