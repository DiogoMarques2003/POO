using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha2_ex1 {
    internal class Centro {
        private int x, y;
        public Centro() {
            x = 0;
            y = 0;
        }

        public Centro(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void CoodCentro() {
            Console.WriteLine("Centro = ({0}, {1})", x, y);
        }
    }
}
