#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void soma(num1, num2);
void subtracao(num1, num2);
void multiplicacao(num1, num2);
void divisao(num1, num2);

int main() {
	setlocale(LC_ALL, "Portuguese");
	
	float num1, num2;
	int opcaoConta;
	
	printf("Introduza o primeiro número: ");
	scanf("%f", &num1);
	printf("Introduza o segundo número: ");
	scanf("%f", &num2);
	
	do {
		printf("Menu de operações:\n");
		printf("1 - soma;\n");
		printf("2 - subtração;\n");
		printf("3 - multiplicação;\n");
		printf("4 - divisão;\n");
		printf("0 - sair;\n");
		printf("Qual operação vai querer fazer: ");
		scanf("%d", opcaoConta)
		
		switch (opcaoConta) {
			case 1:
				soma(num1, num2);
				break;
			case 2:
				subtracao(num1, num2);
				break;
			case 3:
				multiplicacao(num1, num2);
				break;
			case 4:
				divisao(num1, num2);
				break;
			case 0:
				printf("A sair...");
				break;
			default:
				printf("Opção invalida, tente novamente.");
				break;s
		}
	} while (opcao != 0);
	
	return 0;
}

void soma(num1, num2) {
	printf("%f + %f = %.2f", num1, num2, num1 + num2);
}

void subtracao(num1, num2) {
	printf("%f - %f = %.2f", num1, num2, num1 - num2);
}

void multiplicacao(num1, num2) {
	printf("%f X %f = %.2f", num1, num2, num1 * num2);
}

void divisao(num1, num2) {
	printf("%f % %f = %.2f", num1, num2, num1 / num2);
}

