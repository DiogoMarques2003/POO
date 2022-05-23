using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acesso_db {
    internal class Cliente {
        private int id;
        private string nome;
        private int numero;

        public Cliente() {
            id = 0;
            nome = "";
            numero = 0;
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public int Numero {
            get { return numero; }
            set { numero = value; }
        }



    }
}
