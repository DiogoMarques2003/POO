using System;

namespace ex5 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetorA = { 4, 2, 5, 4, 3, 5, 2, 2, 4 };

            int[] vetorB = new int[10];

            for (int i = 0; i < vetorA.Length - 1; i++) {
                vetorB[vetorA[i]]++;
            }

            for (int i = 0; i < vetorB.Length - 1; i++) {
                if (vetorB[i] > 0) {
                    Console.WriteLine("O elemento {0} aparece {1} vezes", i, vetorB[i]);
                }
            }
        }
    }
}
