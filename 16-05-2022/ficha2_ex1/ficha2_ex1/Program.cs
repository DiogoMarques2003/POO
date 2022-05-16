using System;

namespace ficha2_ex1 {
    internal class Program {
        static void Main(string[] args) {
            int n = 4;

            Circulo[] C = new Circulo[n];

            int x = 0, y = 0;
            double r = 0.5;

            for (int i = 0; i < n; i++) {
                C[i] = new Circulo(x, y, r);
                C[i].CoodCentro();
                
                Console.WriteLine("Area = {0}", C[i].Area());
                x++;
                y++;
                r *= 2;
            }
        }
    }
}
