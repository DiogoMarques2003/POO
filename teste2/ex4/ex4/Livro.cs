using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4 {
    internal class Livro : Economia {
        private string editor;

        public string Editor {
            get { return editor; }
            set { editor = value; }
        }

        public Livro(string titulo, string autor, int anoEdicao, string editor) : base(titulo, autor, anoEdicao) {
            this.editor = editor;
        }

        public void posteriorAno(int ano) {
            if (this.AnoEdicao >= ano) {
                Console.WriteLine(this.ToString());
            }
        }
    }
}
