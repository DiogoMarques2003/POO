using System;

namespace ex19
{
    internal class Program
    {
        enum Situacao {
            Aprovado,
            Oral,
            Reprovado
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Geral\t{0}", Situacao.Aprovado);
            Console.WriteLine("Número\t{0}", 2);
        }
    }
}
