using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros {
    internal class Livro {
        //attributes
        private int id;
        private string titulo;
        private string autor;
        private string editora;
        private DateTime dataPub;

        //Contruct
        public Livro() { }

        //Attributes instance
        public int Id { 
            get { return this.id; }
            set { this.id = value; }
        }

        public string Titulo {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public string Autor {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public string Editora {
            get { return this.editora; }
            set { this.editora = value; }
        }

        public DateTime DataPub {
            get { return this.dataPub; }
            set { this.dataPub = value; }
        }
    }
}
