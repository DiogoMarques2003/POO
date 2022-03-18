using System;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, i, factorial;

            Console.Write("Introduza um número para calcular o factorial: ");
            factorial = numero = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < numero; i++) {
                factorial *= i;
            }

            Console.WriteLine("O factorial do número {0} é: {1}", numero, factorial);
        }
    }
}
