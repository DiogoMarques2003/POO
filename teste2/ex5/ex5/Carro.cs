using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5 {
    internal class Carro : ISumario {
        private string marca;
        private string modelo;

        public Carro(string marca, string modelo) {
            this.marca = marca;
            this.modelo = modelo;
        }

        public void imprimeDadosCarro() {
            Console.WriteLine("Marca: {0}; Modelo: {1}", this.marca, this.modelo);
        }

        public void imprimeDadosPessoa() {
            throw new NotImplementedException();
        }

        public void imprimeDadosTelemove() {
            throw new NotImplementedException();
        }
    }
}
