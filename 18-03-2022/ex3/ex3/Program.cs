using System;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura, comprimento, i, j;

            Console.Write("Introduza a largura do retângulo: ");
            largura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduza o comprimento do retângulo: ");
            comprimento = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < comprimento; i++) {
                for (j = 0; j < largura; j++) {
                    if (i == 0 || i == comprimento-1 || j == 0 || j == largura - 1) {
                        Console.Write('X');
                    } else {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
