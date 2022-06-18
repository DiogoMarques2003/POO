using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3 {
    internal class Viagem {
        private double kmInicial;
        private double gasolinaInicial;

        public Viagem(double kmInicial, double gasolinaInicial) {
            this.kmInicial = kmInicial;
            this.gasolinaInicial = gasolinaInicial;
        }

        public double KmInicial {
            get { return kmInicial; }
            set { this.kmInicial = value; }
        }

        public double GasolinaInicial {
            set { this.gasolinaInicial = value; }
            get { return gasolinaInicial; }
        }

        public void calcularMedia100KM(double kmFinal, double gasolinaFinal, double precoGasolina) {
            double kmPercorridos = kmFinal - this.kmInicial;
            double litrosConsumidos = this.gasolinaInicial - gasolinaFinal;

            double consumoMedio100km = Math.Round(((litrosConsumidos / kmPercorridos) * 100), 2);

            Console.WriteLine("O consumo de gasolina por 100km foi {0}, que custo {1}€", consumoMedio100km, consumoMedio100km * precoGasolina);
        }
    }
}
