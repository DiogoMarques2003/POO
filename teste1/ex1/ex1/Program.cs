using System;

namespace ex1 {
    internal class Program {
        static void Main(string[] args) {
            int numero;

            Console.Write("Introduza um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O número introduzido foi {0}", numero);
        }
    }
}
