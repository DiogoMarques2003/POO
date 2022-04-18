using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa {
    public partial class Form1 : Form {

        Casa casa = new Casa();

        public Form1() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            txtCor.Text = "";
            txtNum.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e) {
            casa.Cor = txtCor.Text;
            casa.Numero = Convert.ToInt32(txtNum.Text);

            string msg = "Cor: " + casa.Cor + "\nNúmero:" + casa.Numero.ToString();

            MessageBox.Show(msg, "Dados da casa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e) {
            DialogResult resposta = MessageBox.Show("Queres mesmo sair do programa?", "Sair do programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes) {
                Application.ExitThread();
            }
        }
    }
}
