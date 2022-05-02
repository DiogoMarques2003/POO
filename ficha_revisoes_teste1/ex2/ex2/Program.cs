using System;

namespace ex2 {
    internal class Program {
        static void Main(string[] args) {
            float numero = 0.33449982F;

            Console.WriteLine(String.Format("Percentagem: {0:P2}.", numero));

            Console.WriteLine("Número arredondando a 1 casa decimal: {0}", Math.Round(numero, 1));
            Console.WriteLine("Número arredondando a 2 casa decimal: {0}", Math.Round(numero, 2));
            Console.WriteLine("Número arredondando a 3 casa decimal: {0}", Math.Round(numero, 3));
        }
    }
}
