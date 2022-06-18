using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1 {
    internal class Professor : Pessoa {
        public string grupo;
        public int numFuncionario;

        public Professor(string nome, int idade, string grupo, int numFuncionario) : base (nome, idade) {
            this.grupo = grupo;
            this.numFuncionario = numFuncionario;
        }

       public override string ToString() {
            return this.nome + ", " + this.idade + " anos, " + this.grupo + ", " + this.numFuncionario;
        }
    }
}
