using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca {
    internal class Pessoa {
        //Atributos
        private string nome;
        private int idade;
        private string morada;

        //Constructor
        public Pessoa() { }

        public Pessoa(string nome, int idade, string morada) {
            this.nome = nome;
            this.idade = idade;
            this.morada = morada;
        }

        //Getters e setters
        public string Nome {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Idade {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public string Morada {
            get { return this.morada; }
            set { this.morada = value; }
        }

        public string ToString() {
            return "Nome: " + this.nome + "; Idade: " + this.idade.ToString() + "; Morada: " + this.morada;
        }
    }
}
