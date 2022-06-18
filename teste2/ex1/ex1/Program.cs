using System;

namespace ex1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ex 1:");

            Pessoa pessoa = new Pessoa();
            int continueLoop = 1;

            do {
                Console.Write("Introduza o nome da pessoa: ");
                pessoa.Nome = Console.ReadLine();
                if (pessoa.Nome.ToUpper() == "ZZZ") {
                    continueLoop = 0;
                    continue;
                }

                Console.Write("Introduza o sexo da pessoa [f|m]: ");
                pessoa.Sexo = Console.ReadLine();
                while (pessoa.Sexo.ToLower() != "f" && pessoa.Sexo.ToLower() != "m") {
                    Console.WriteLine("Sexo inválido, tem de ser f ou m.");
                    Console.Write("Introduza o sexo da pessoa [f|m]: ");
                    pessoa.Sexo = Console.ReadLine();
                }

                Console.Write("Introduza a idade da pessoa: ");
                pessoa.Idade = int.Parse(Console.ReadLine());

                pessoa.classificarPessoa();
            } while (continueLoop == 1);

            Pessoa.mostrarContadores(pessoa.devolveContadores());
        }
    }
}
