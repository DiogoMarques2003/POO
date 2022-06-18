using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4 {
    abstract class DuasDimen : Forma {
        private float x, y;

        public float X {
            get { return x; }
            set { x = value; }
        }

        public float Y {
            get { return y; }
            set { y = value; }
        }

        public DuasDimen(float x, float y) : base() {
            this.x = x;
            this.y = y;
        }
    }
}
