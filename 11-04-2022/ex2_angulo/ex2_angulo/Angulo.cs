using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_angulo {
    internal class Angulo {
        private double grau;
        private double radiano;

        public Angulo() {
            this.grau = 0;
            this.radiano = 0;
        }

        public double calcGrau(double radiano) {
            this.grau = radiano / Math.PI * 180;

            return this.grau;
        }

        public double calcRadiano(double grau) {
            this.radiano = grau / 180 * Math.PI;

            return this.radiano;
        }
    }
}
