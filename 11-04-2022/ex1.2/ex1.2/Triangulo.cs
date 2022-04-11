using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1._2 {
    internal class Triangulo {
        //vars
        private double _ladoA;
        private double _ladoB;
        private double _ladoC;

        //Contructor
        public Triangulo() { }

        //methods
        public void dimensoes(double ladoA, double ladoB, double ladoC) {
            this._ladoA = ladoA;
            this._ladoB = ladoB;
            this._ladoC = ladoC;
        }

        public string tipo() {
            if (_ladoA == _ladoB && _ladoB == _ladoC) return "Equilátero";
            else if (_ladoA == _ladoB || _ladoB == _ladoC || _ladoA == _ladoC) return "Isósceles";
            else return "Escaleno";
        }
    }
}
