using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_exercicio {
    internal class Aviao {
        //var
        private string _modelo;
        private float _velocidade;
        private float _altitude;
        private string _marca;

        //Constructor
        public Aviao() {}

        //method
        public void reduzir() {
            Console.WriteLine("Reduzir");
        }

        public void descer() {
            Console.WriteLine("Descer");
        }

        public void acelarar() {
            Console.WriteLine("Acelarar");
        }

        public string subir() {
            return "Subir";
        }
    }
}
