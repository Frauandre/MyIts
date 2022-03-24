/* OUTPUT: 22/11/2021 | Errore*/
#include <stdio.h>
int main(){
	
int g, m, a;
printf("Giorno:");
scanf("%d", &g);

printf("Mese:");
scanf("%d", &m);

printf("Anno:");
scanf("%d", &a);

if(g<1 || g>31 || m<1 || m>12 || a<1582)
  printf("Errore");
else if ((m==4 || m==6 || m==9 || m==11) && g==31)
  printf("Errore");
else if(m==2 && g>=30)
  printf ("Errore");
else if(m==2 && g==29 && a%4!=0)
  printf("Errore");
else
  printf("%d/%d/%d", g, m, a);
}
