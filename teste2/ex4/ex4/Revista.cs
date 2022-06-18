using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4 {
    internal class Revista : Economia {
        private string nomeRevista;
        private int numero;

        public string NomeRevista {
            get { return nomeRevista; }
            set { nomeRevista = value; }
        }

        public int Numero {
            get { return numero; }
            set { numero = value; }
        }

        public Revista(string titulo, string autor, int anoEdicao, string nomeRevista, int numero) : base(titulo, autor, anoEdicao) {
            this.nomeRevista = nomeRevista;
            this.numero = numero;
        }

        public void posteriorAno(int ano) {
            if (this.AnoEdicao >= ano) {
                Console.WriteLine(this.ToString());
            }
        }
    }
}
