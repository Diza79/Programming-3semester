// ConsoleApplication3.cpp: определяет точку входа для консольного приложения.
// Простейший пример ммх - сложение двух векторов А и В, результат в С

#include "stdafx.h"


int main(){
	
	signed char a[8], b[8], c[8];

	printf("signed char length = %d \n\r", sizeof(signed char));
	printf("input vector A \n \r");
	for(int i=0;i<=7;i++)
		scanf("%d",&a[i]);
	printf("input vector B \n \r");
	for(int i=0;i<=7;i++)
	    scanf("%d", &b[i]);
	_asm {
		movq mm0, qword ptr[a]
		movq mm1,[b]
		paddb mm0,mm1
		movq [c],mm0
	}
	printf("result vector C \n\r");
	for (int i = 0; i <= 7; i++)
		printf("c[%d] = %d   ",i,c[i]);
	printf("\n\r");
	return 0;
}

