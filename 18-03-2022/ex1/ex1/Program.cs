using System;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0, i;

            Console.Write("Introduza um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++) {
                soma += i;
            }

            Console.WriteLine("A soma dos {0}º números é: {1}", n, soma);
        }
    }
}
