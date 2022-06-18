using System;

namespace ex5 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ex 5:");

            Pessoa pessoa = new Pessoa("Diogo", "Marques");
            Carro carro = new Carro("BMW", "serie 1");
            Telemovel telemovel = new Telemovel("Samsung", 123);

            pessoa.imprimeDadosPessoa();
            carro.imprimeDadosCarro();
            telemovel.imprimeDadosTelemove();
        }
    }
}
