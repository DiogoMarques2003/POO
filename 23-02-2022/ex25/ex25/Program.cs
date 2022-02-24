using System;

namespace ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolares, cotacao, euros;

            Console.Write("Introduza a quantia de dólares americanos: ");
            dolares = double.Parse(Console.ReadLine());

            Console.Write("Introduza a cotação do dólar em euros: ");
            cotacao = double.Parse(Console.ReadLine());

            euros = dolares * cotacao;
            Console.WriteLine("{0} dólares americanos equivalem a {1} euros", dolares, euros);
        }
    }
}
