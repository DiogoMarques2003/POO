using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca {
    internal class Aluno : Pessoa /* Herança */ {
        //atributes
        private string curso;
        private string semestre;

        //Constructor
        public Aluno() { }
        public Aluno(string nome, int idade, string morada, string curso, string semestre) : base(nome, idade, morada) {
            this.curso = curso;
            this.semestre = semestre;
        }

        //Getters e setters
        public string Curso {
            get { return this.curso; }
            set { this.curso = value; }
        }

        public string Semestre {
            get { return this.semestre; }
            set { this.semestre = value; }
        }

        public string ToString() {
            return "Nome do Aluno: " + this.Nome + "; Idade: " + this.Idade.ToString() + "; Morada: " + this.Morada + "; Curso: " + this.curso + "; Semestre: " + this.semestre;
        }
    }
}
