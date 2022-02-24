using System;

namespace ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cat1, cat2, hipotenusa;

            Console.Write("Introduza o valor da primeira catetopo do triângulo retângulo: ");
            cat1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o valor da segunda catetopo do triângulo retângulo: ");
            cat2 = double.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));

            Console.WriteLine("A hipotenusa do triângulo retângulo é: {0:0.00}", hipotenusa);
        }
    }
}
