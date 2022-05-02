using System;

namespace ex6 {
    internal class Program {
        static void Main(string[] args) {
            int somaIdades = 0;
            int contadorUtentes = 0;
            int idade;

            Console.Write("Introduza a idade do utente (000 para terminar): ");
            idade = Convert.ToInt32(Console.ReadLine());

            while (idade != 000) {
                contadorUtentes++;
                somaIdades += idade;

                Console.Write("Introduza a idade do utente (000 para terminar): ");
                idade = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("A idade média dos {0} utentes" + "={1, 4:F2} anos", contadorUtentes, somaIdades / contadorUtentes);
        }
    }
}
