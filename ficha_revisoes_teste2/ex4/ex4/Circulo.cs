using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4 {
    internal class Circulo : DuasDimen {
        public Circulo (float x, float y) : base (x, y) { }

        public void Area() {
            float area = (float)(this.X * Math.Pow(this.Y, 2));

            Console.WriteLine("Forma: Círculo - Área: {0} ~> ({1})", area, this.Y);
        }
    }
}
