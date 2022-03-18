using System;

namespace ex6 {
    internal class Program {
        static void Main(string[] args) {
            int num1 = 0, num2 = 1, aux;

            Console.WriteLine("20 primeiros número de Fibonacci.");

            for (int i = 0; i < 20; i++) {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
                Console.WriteLine(num2);
            }


        }
    }
}
