using System;

namespace ex10 {
    internal class Program {
        static void Main(string[] args) {
            string nome, sexo;
            int idade;

            Console.Write("Introduza o nome da pessoa: ");
            nome = Console.ReadLine();

            Console.Write("Introduza o sexo da pessoa (m - masculino/f - femenino): ");
            sexo = Console.ReadLine().ToLower();
            while(sexo != "m" && sexo != "f") {
                Console.WriteLine("Sexo invalido.");
                Console.Write("Introduza o sexo da pessoa (m - masculino/f - femenino): ");
                sexo = Console.ReadLine().ToLower();
            }

            Console.Write("Introduza a idade da pessoa: ");
            idade = Convert.ToInt32(Console.ReadLine());
            while (idade < 0 || idade > 100) {
                Console.WriteLine("Idade invalida, tem de ser entre 0 e 100.");
                Console.Write("Introduza a idade da pessoa: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }

            if (idade < 45) {
                Console.WriteLine("A pessoa {0} não precisa de fazer o exame.", nome);
            } else if (sexo == "m") {
                Console.WriteLine("A pessoa {0} tem que fazer um exame ao estômago.", nome);
            } else if (sexo == "f") {
                Console.WriteLine("A pessoa {0} tem que fazer um exame aos pulmões.", nome);
            }
        }
    }
}
