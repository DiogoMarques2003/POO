using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros {
    internal class Carro {
        //Atributos
        private string matricula;
        private string marca;
        private string modelo;
        private string dono;
        private DateTime dataCriacao;

        //constructor
        public Carro() { }

        //Getters e setter
        public string Matricula {
            get { return this.matricula; }
            set { this.matricula = value; }
        }

        public string Marca {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Modelo {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public string Dono {
            get { return this.dono; }
            set { this.dono = value; }
        }

        public DateTime DataCriacao {
            get { return this.dataCriacao; }
            set { this.dataCriacao = value; }
        }
    }
}
