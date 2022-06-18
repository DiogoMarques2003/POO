using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5 {
    internal class Pessoa : ISumario {
        private string titulo;
        private string apelido;

        public Pessoa(string titulo, string apelido) {
            this.titulo = titulo;
            this.apelido = apelido;
        }

        public void imprimeDadosPessoa() {
            Console.WriteLine("Titulo: {0}; Apelido: {1}", this.titulo, this.apelido);
        }

        public void imprimeDadosCarro() {
            throw new NotImplementedException();
        }

        public void imprimeDadosTelemove() {
            throw new NotImplementedException();
        }
    }
}
