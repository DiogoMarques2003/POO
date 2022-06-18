using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3 {
    internal class DVD : Album {
        private bool extras;

        public DVD(string nome, string artista, string banda, int ano, bool extras) : base(nome, artista, banda, ano) {
            this.extras = extras;
        }

        public void Play() {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine("No leitor de DVD's está:");
            if (extras) Console.WriteLine(this.nome + ", " + this.ano + "\n" + this.banda + "" + this.artista + "\nCom extras");
            else Console.WriteLine(this.nome + ", " + this.ano + "\n" + this.banda + "" + this.artista + "\nSem extras");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
        }
    }
}
