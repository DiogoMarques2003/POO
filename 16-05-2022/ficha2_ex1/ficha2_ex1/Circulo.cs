using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha2_ex1 {
    internal class Circulo : Centro {
        private double Raio;
        public Circulo() {
        }

        public Circulo(int x, int y, double R) : base(x, y) {
            Raio = R;
        }

        public double Area() {
            return Math.Round(Math.PI * Math.Pow(Raio, 2), 2);
        }
    }
}
