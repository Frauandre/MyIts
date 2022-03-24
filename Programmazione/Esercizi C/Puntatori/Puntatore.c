/*
es. x=12, y=-3

x=-3, y=12

scambio
*/
#include<stdio.h>

//passaggio di parametri by reference
void scambio(int*x, int*y){
	int tmp=*x;
	*x=*y;
	*y=tmp;
}

int main(){
	
	int x=12;
	int y=-3;
	
	scambio(&x,&y);
	
	printf("\n\nprima -> x: %d, y: %d", x, y);
}
