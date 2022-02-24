using System;

namespace ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capitalInicial, taxaAnualJuros, capitalAcumulado;

            Console.Write("Introduza o capital inicia: ");
            capitalInicial = Double.Parse(Console.ReadLine());

            Console.Write("Introduza a taxa anual de juros: ");
            taxaAnualJuros = Double.Parse(Console.ReadLine());

            capitalAcumulado = capitalInicial * Math.Pow((1+taxaAnualJuros/100), 2);

            Console.WriteLine("{0} euros capitalizado durante 2 anos à taxa anual de {1}% resultam em {2} euros", capitalInicial, taxaAnualJuros, capitalAcumulado);
        }
    }
}
