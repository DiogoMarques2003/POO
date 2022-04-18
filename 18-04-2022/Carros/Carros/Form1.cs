using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros {
    public partial class Form1 : Form {

        Carro carro = new Carro();

        public Form1() {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            //Iniciar o OBJ carro
            carro.Matricula = txtMatricula.Text;
            carro.Marca = txtMarca.Text;
            carro.Modelo = txtModelo.Text;
            carro.Dono = txtDono.Text;
            carro.DataCriacao = DateTime.Parse(txtDataCriacao.Text);

            //Guardar a informação
            lstCarros.Items.Add(carro.Matricula);
            lstCarros.Items.Add(carro.Marca);
            lstCarros.Items.Add(carro.Modelo);
            lstCarros.Items.Add(carro.Dono);
            lstCarros.Items.Add(carro.DataCriacao.ToString());

        }
    }
}
