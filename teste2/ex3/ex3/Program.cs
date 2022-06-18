using System;

namespace ex3 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ex 3:");

            double kmInicial, kmFinal, gasolinaInicia, gasolinaFinal, precoGasolina;

            Console.WriteLine("Dados do inicio da viagem.");

            Console.Write("Introduza os quilómetros indicados no conta-quilómetros: ");
            kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Introduza a gasolina que o depósito contem: ");
            gasolinaInicia = double.Parse(Console.ReadLine());

            Viagem viagem = new Viagem(kmInicial, gasolinaInicia);

            Console.WriteLine("Dados do fim da viagem.");

            Console.Write("Introduza os quilómetros indicados no conta-quilómetros: ");
            kmFinal = double.Parse(Console.ReadLine());
            while (kmFinal <= kmInicial) {
                Console.WriteLine("Os quilómetros atuais não pode ser menos ou iugal aos quilómetros do inicio da viagem.");
                Console.Write("Introduza os quilómetros indicados no conta-quilómetros: ");
                kmFinal = double.Parse(Console.ReadLine());
            }

            Console.Write("Introduza a gasolina que o depósito contem: ");
            gasolinaFinal = double.Parse(Console.ReadLine());
            while (gasolinaFinal >= gasolinaInicia) {
                Console.WriteLine("A gasolina atual não pode ser menos ou igual a gasolina do inicio da viagem.");
                Console.Write("Introduza a gasolina que o depósito contem: ");
                gasolinaFinal = double.Parse(Console.ReadLine());
            }

            Console.Write("Introduza o preço da gasolina: ");
            precoGasolina = double.Parse(Console.ReadLine());

            viagem.calcularMedia100KM(kmFinal, gasolinaFinal, precoGasolina);
        }
    }
}
