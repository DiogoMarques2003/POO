using System;

namespace ex4_v2 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetorA = {4, 2, 5, 4, 3, 5, 2, 2, 4};
            int tamanhoVetorA = vetorA.Length - 1;
            int[] Conta = new int[tamanhoVetorA + 1];

            for (int i = 0; i < tamanhoVetorA; i++) {
                Conta[i] = 1;
            }

            for (int i = 0; i < tamanhoVetorA; i++) {
                if (Conta[i] != 0) {
                    for (int j = i + 1; j <= tamanhoVetorA; j++) {
                        if (vetorA[i] == vetorA[j]) {
                            Conta[i]++;
                            Conta[j] = 0;
                        }
                    }
                }
            }

            for (int i = 0; i <= tamanhoVetorA; i++) {
                if (Conta[i] != 0) {
                    Console.WriteLine(" {0, 4} ocorre {1, 2} vez(es) em A", vetorA[i], Conta[i]);
                }
            }
        }
    }
}
