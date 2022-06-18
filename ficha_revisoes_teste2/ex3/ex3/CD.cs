using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3 {
    internal class CD: Album {
        private int numCDs;

        public CD(string nome, string artista, string banda, int ano, int numCDs) : base(nome, artista, banda, ano) {
            this.numCDs = numCDs;
        }

        public void Play() {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine("No leitor de CD's está:");
            Console.WriteLine(this.nome + ", " + this.ano + "\n" + this.banda + "" + this.artista + "\nNúmero de CD's: " + this.numCDs);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
        }
    }
}
