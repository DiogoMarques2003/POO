using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2 {
    internal class Triangulo {
        private double altura;
        private double baseT;

        public Triangulo(double altura, double baseT) {
            this.altura = altura;
            this.baseT = baseT;
        }

        public double Altura {
            get { return altura; }
            set { altura = value; }
        }

        public double BaseT {
            get { return baseT; }
            set { baseT = value; }
        }

        public double Area() {
            return (altura * baseT) / 2;
        }

        public double[] Ampliacao(double x) {
            double[] dimensoesAmpleadas = {altura*x, baseT*x};

            return dimensoesAmpleadas;
        }
    }
}
