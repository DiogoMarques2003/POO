using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4 {
    abstract class Economia {
        private string titulo;
        private string autor;
        private int anoEdicao;

        public string Titulo {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor {
            get { return autor; }
            set { autor = value; }
        }

        public int AnoEdicao {
            get { return anoEdicao; }
            set { anoEdicao = value; }
        }

        public Economia(string titulo, string autor, int anoEdicao) {
            this.titulo = titulo;
            this.autor = autor;
            this.anoEdicao = anoEdicao;
        }

        public override string ToString() {
            return "Titulo: " + this.titulo + ", Autores: " + this.autor + ", Ano Edição: " + this.anoEdicao;
        }
    }
}
