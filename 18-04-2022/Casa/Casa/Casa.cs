using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa {
    internal class Casa {
        //Atributos
        private string cor;
        private int numero;

        //Constructor
        public Casa() { }

        //Getters e setters
        public string Cor {
            get { return this.cor; }
            set { this.cor = value; }
        }

        public int Numero {
            get { return this.numero; }
            set { this.numero = value; }
        }
    }
}
