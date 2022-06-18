using System;

namespace ex6 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ex 6:");

            double[] valores = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            AnaliseDados analiseDados = new AnaliseDados(valores.Length, valores);

            Console.WriteLine("Média: {0};\nVariancia: {1};\nDesvio Padrão: {2}", analiseDados.Media(), analiseDados.Variancia(2), analiseDados.DesvioPadrao(2));
        }
    }
}
