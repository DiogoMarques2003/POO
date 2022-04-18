using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca {
    internal class Professor : Pessoa {
        //atributos
        private string titulo;
        private string especialidade;
        private double salario;

        //Construct
        public Professor() { }
        public Professor(string nome, int idade, string morada, string titulo, string especialidade, double salario) : base (nome, idade, morada) {
            this.titulo = titulo;
            this.especialidade = especialidade;
            this.salario = salario;
        } 

        public string Titulo {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public string Especialidade {
            get { return this.especialidade; }
            set { this.especialidade = value; }
        }

        public double Salario {
            get { return this.salario; }
            set { this.salario = value; }
        }

        public string ToString() {
            return "Nome do Professor: " + this.Nome + "; Idade: " + this.Idade.ToString() + "; Morada: " + this.Morada + "; Titulo: " + this.titulo + "; Especialidade: " + this.especialidade + "; Salario: " + this.salario;
        }
    }
}
