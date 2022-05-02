using System;

namespace ex9 {
    internal class Program {
        static void Main(string[] args) {
            int numero, postivos = 0, negativos = 0;

            for (int i = 0; i < 5; i++) {
                Console.Write("Introduza o {0}º número: ", i + 1);
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0) continue;
                else if (numero > 0) postivos++;
                else negativos++;
            }

            Console.WriteLine("Introduziste {0} número positivos e {1} números negativos", postivos, negativos);
        }
    }
}
