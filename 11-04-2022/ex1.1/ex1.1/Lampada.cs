using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1._1 {
    internal class Lampada {
        //vars
        private bool _ligada;

        //constructor
        public Lampada() {
            _ligada = false;
        }

        //methods
        public void acender() {
            _ligada = true;
        }

        public void apagar() {
            _ligada = false;
        }

        public string estado() {
            if (_ligada) return "Lidaga";
            else return "Desligada";
        }
    }
}
