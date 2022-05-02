using System;

namespace ex3 {
    internal class Program {
        static void Main(string[] args) {
            int menor = int.MaxValue;

            for (int i = 0; i < 3; i++) {
                Console.Write("Introduza o {0}º número: ", (i + 1));
                int num = Convert.ToInt32(Console.ReadLine());

                if (menor > num) menor = num;
            }

            Console.WriteLine("O menor número introduzido foi {0}", menor);
        }
    }
}
