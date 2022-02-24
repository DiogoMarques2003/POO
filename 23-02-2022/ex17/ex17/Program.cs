using System;

namespace ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float percentagem = (float)0.456789 * 100;

            Console.WriteLine("1 casa decimal: {0:0.0}%", percentagem);
            Console.WriteLine("2 casa decimal: {0:0.00}%", percentagem);
            Console.WriteLine("3 casa decimal: {0:0.000}%", percentagem);
        }
    }
}
