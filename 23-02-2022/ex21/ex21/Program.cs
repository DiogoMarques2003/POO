using System;

namespace ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Boa tarde, {0}!", name);
        }
    }
}
