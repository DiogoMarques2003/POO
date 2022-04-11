using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora {
    internal class Calculadora {
        //vars
        private int _num1;
        private int _num2;

        //constructor
        public Calculadora() {}

        //methods
        public void setNum1(int num1) {
            _num1 = num1;
        }

        public void setNum2(int num2) {
            _num2 = num2;
        }

        public int soma() {
            return _num1 + _num2;
        }

        public int subtrair() {
            return _num1 - _num2;
        }

        public int multiplicar() {
            return _num1 * _num2;
        }

        public float dividir() {
            return _num1 / _num2;
        }
    }
}
