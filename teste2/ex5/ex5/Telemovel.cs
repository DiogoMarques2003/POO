using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5 {
    internal class Telemovel: ISumario {
        private string marca;
        private int numero;

        public Telemovel(string marca, int numero) {
            this.marca = marca;
            this.numero = numero;
        }

        public void imprimeDadosTelemove() {
            Console.WriteLine("Marca: {0}; Número: {1}", this.marca, this.numero);
        }

        public void imprimeDadosCarro() {
            throw new NotImplementedException();
        }

        public void imprimeDadosPessoa() {
            throw new NotImplementedException();
        }
    }
}
