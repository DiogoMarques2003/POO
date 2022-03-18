using System;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max, i;

            Console.Write("Introduza o 1º múmero: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduza o 2º número: ");
            max = Convert.ToInt32(Console.ReadLine());

            while (min > max) {
                Console.Write("O 2º número tem de ser maior que {0}.\nIntroduza denovo o 2º número: ", min);
                max = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Números impars entre {0} e {1}", min, max);

            for (i = min; i <= max; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
