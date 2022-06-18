using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6 {
    internal class AnaliseDados : MaisEstatisticas {
        private double dimensao;
        private double[] valoresObservador;

        public AnaliseDados(double dimensao, double[] valoresObservador) {
            this.dimensao = dimensao;
            this.valoresObservador = valoresObservador;
        }

        public double DesvioPadrao(double V) {
            return Math.Sqrt(Variancia(V));
        }

        public double Media() {
            double soma = 0;

            for (int i = 0; i < this.valoresObservador.Length; i++) {
                soma += this.valoresObservador[i];
            }

            return soma / this.valoresObservador.Length;
        }

        public double Variancia(double M) {
            double media = this.Media();

            double diff = 0;

            for (int i = 0; i < this.valoresObservador.Length; i++) {
                diff += (this.valoresObservador[i] - media) * (this.valoresObservador[i] - media);
            }

            return diff / this.valoresObservador.Length;
        }
    }
}
