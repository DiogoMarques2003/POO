using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3 {
    internal class Vinil : Album {
        private string tipo;

        public Vinil(string nome, string artista, string banda, int ano, string tipo) : base (nome, artista, banda, ano) {
            this.tipo = tipo;
        }

        public void Play() {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine("No gira-discos está:");
            Console.WriteLine(this.nome + ", " + this.ano + "\n" + this.banda + "" + this.artista + "\nTipo: " + this.tipo);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
        }
    }
}
