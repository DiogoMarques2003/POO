using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1 {
    abstract class Pessoa {
        protected string nome;
        protected int idade;

        public Pessoa(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;
        }

        public string Nome {
            get { return nome; }
            set { this.nome = value; }
        }

        public int Idade {
            get { return idade; }
            set { this.idade = value; }
        }

        public override string ToString() {
            return this.nome + ", " + this.idade + " anos";
        }
    }
}
