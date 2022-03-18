using System;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho, i, j;

            Console.Write("Qual o tamanho do quadrado: ");
            tamanho = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < tamanho; i++) {
                for (j = 0; j < tamanho; j++) {
                    if ((i + j) % 2 == 0) {
                        Console.Write('O');
                    } else {
                        Console.Write('X');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
