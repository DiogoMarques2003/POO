using System;

namespace ex8 {
    internal class Program {
        static void Main(string[] args) {
            double valorProduto, valorDesconto, valorDescontoProduto, totalValorProdutos = 0, taxaDoIva, valorIva, valorTotalComIva;
            string continuarIntroduzirProdutos = "s";

            do {
                Console.Write("Introduza o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Introduza o valor do desconto: ");
                valorDesconto = Convert.ToDouble(Console.ReadLine());

                valorDescontoProduto = valorProduto * valorDesconto / 100;

                Console.WriteLine("Valor do produto com desconto: {0}€", valorProduto - valorDescontoProduto);

                totalValorProdutos += valorProduto - valorDescontoProduto;

                Console.Write("Deseja introduzir mais produtos? (s/S para continar): ");
                continuarIntroduzirProdutos = Console.ReadLine();
                Console.WriteLine();
            } while (continuarIntroduzirProdutos == "s" || continuarIntroduzirProdutos == "S");

            Console.Write("Qual é a taxa do iva: ");
            taxaDoIva = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            valorIva = totalValorProdutos * taxaDoIva / 100;
            valorTotalComIva = totalValorProdutos + valorIva;

            Console.WriteLine("Iva a ser pago: {0}€", valorIva);
            Console.WriteLine("Valor total sem o iva: {0}€", totalValorProdutos);
            Console.WriteLine("Valor final da compra: {0}€", valorTotalComIva);
        }
    }
}
