using System;

namespace ex5 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número de camionistas: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] tempo = new double[n];
            int i = 0;
            double soma = 0;
            double media = 0;

            while (i < n) {
                Console.Write("Digite o tempo de carga do {0}º camionis: ", (i+1));
                tempo[i] = double.Parse(Console.ReadLine());
                i++;
            }

            i = 0;

            while (i < n) {
                soma += 1 / tempo[i];
                i++;
            }

            media = n / soma;

            Console.WriteLine("A média harmônica é: {0}", Math.Round(media, 2));
        }
    }
}
