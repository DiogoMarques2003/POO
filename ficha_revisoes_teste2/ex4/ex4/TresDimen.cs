using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4 {
    abstract class TresDimen {
        private float x, y, z;

        public float X {
            get { return x; }
            set { x = value; }
        }

        public float Y {
            get { return y; }
            set { y = value; }
        }

        public float Z {
            get { return z; }
            set { z = value; }
        }

        public TresDimen(float x, float y, float z) : base() {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
