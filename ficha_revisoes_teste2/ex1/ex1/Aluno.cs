using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1 {
    internal class Aluno: Pessoa {
        public int numMecanografico;
        public string curso;

        public Aluno(string nome, int idade) : base(nome, idade) {
            this.numMecanografico = 0;
            this.curso = "---";
        }

        public Aluno(string nome, int idade, int numMecanografico, string curso) : base (nome, idade) {
            this.numMecanografico = numMecanografico;
            this.curso = curso;
        }

        public override string ToString() {
            return this.nome + ", " + this.idade + " anos, " + this.numMecanografico + ", " + this.curso;
        }
    }
}
