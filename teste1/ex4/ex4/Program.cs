using System;

namespace ex4 {
    internal class Program {
        static void Main(string[] args) {
            int idade;

            Console.Write("Introduza a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            while (idade < 17 || idade > 77) {
                Console.WriteLine("A idade não é >= 17 e <= 77");
                Console.Write("Introduza a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Idade validada: {0} anos", idade);
        }
    }
}
