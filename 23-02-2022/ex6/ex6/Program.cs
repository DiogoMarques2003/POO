using System;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 + 3 x (15 - 2) = {0}", 4+3*(15-2));
            Console.WriteLine("40 / 9 = {0}", Math.Round((float)40 / 9, 2));
            Console.WriteLine("Resto da divisão de 40 por 3 = {0}", 40 % 3);
        }
    }
}
