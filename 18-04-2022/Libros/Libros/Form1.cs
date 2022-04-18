using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros {
    public partial class Form1 : Form {
    
        Livro livro = new Livro();

        public Form1() {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            //Instancia do obj livro
            livro.Id = Convert.ToInt32(txtId.Text);
            livro.Titulo = txtTitulo.Text;
            livro.Autor = txtAutor.Text;
            livro.Editora = txtEditora.Text;
            livro.DataPub = DateTime.Parse(txtDataPub.Text);

            //Inserir na lista
            lstLivro.Items.Add(livro.Id.ToString());
            lstLivro.Items.Add(livro.Titulo);
            lstLivro.Items.Add(livro.Autor);
            lstLivro.Items.Add(livro.Editora);
            lstLivro.Items.Add(livro.DataPub.ToString());
        }
    }
}
