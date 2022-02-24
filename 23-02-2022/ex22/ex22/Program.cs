using System;

namespace ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> func = (double x, double y) => (y + Math.Sqrt(2*x+10)) / (2*x);

            string num1, num2;

            Console.Write("Introduza o 1º número: ");
            num1 = Console.ReadLine();

            Console.Write("Introduza o 2º número: ");
            num2 = Console.ReadLine();

            Console.WriteLine("Resultado: {0:0.000}", func(Double.Parse(num1), Double.Parse(num2)));
        }
    }
}
