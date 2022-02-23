using System;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 ^ 5 = {0}", Math.Pow(3, 5));
            Console.WriteLine("Raiz quadrada de 125 = {0}", Math.Round(Math.Sqrt(125), 2));
            Console.WriteLine("5.00 aredondado a 0 casas decimais = {0}", Math.Round(5.00, 0));
            Console.WriteLine("Seno de 30º = {0}", Math.Round(Math.Sin(30 * Math.PI / 180), 2));
        }
    }
}
