using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_angulo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double resultado = 0;

            if (textBox1.Text != "") {
                resultado = new Angulo().calcRadiano(Convert.ToDouble(textBox1.Text));
            } else if (textBox2.Text != "") {
                resultado = new Angulo().calcGrau(Convert.ToDouble(textBox2.Text));
            }

            label4.Text = resultado.ToString();
        }
    }
}
