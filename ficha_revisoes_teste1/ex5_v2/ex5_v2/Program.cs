using System;

namespace ex5_v2 {
    internal class Program {
        static void Main(string[] args) {
            double medh = 0;
            int c = 0;

            Console.Write("Tempo médio do camionista (000 para terminar): ");
            double tempoMed = Convert.ToInt32(Console.ReadLine());

            while (tempoMed != 000) {
                c++;
                medh += 1 / tempoMed;
                Console.Write("Tempo médio do camionista (000 para terminar): ");
                tempoMed = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Tempo médio por carga dos {0} camionistas" + "={1, 4:F2} horas", c, c / medh);
        }
    }
}
