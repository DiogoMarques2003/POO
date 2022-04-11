using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_pessoa {
    internal class Pessoa {
        //vars
        private string _nome;
        private int _idade;

        //constructors
        public Pessoa() {}

        public Pessoa(string nome, int idade) {
            _nome = nome;
            _idade = idade;
        }

        public Pessoa(string nome) {
            _nome =nome;
        }

        public Pessoa(int idade) {
            _idade = idade;
        }

        //methods
        public void verInfo() {
            Console.WriteLine("Nome {0}; Idade {1}", _nome, _idade);
        }
    }
}
