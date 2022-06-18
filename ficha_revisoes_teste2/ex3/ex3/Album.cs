using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3 {
    abstract class Album {
        protected string nome;
        protected string artista = null;
        protected string banda = null;
        protected int ano;

        public Album(string nome, string artista, string banda, int ano) {
            this.nome = nome;
            this.artista = artista;
            this.banda = banda;
            this.ano = ano;
        }

        public void Play() {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine(this.nome + ", " + this.ano + "\n" + this.banda + "" + this.artista);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
        }
    }
}
