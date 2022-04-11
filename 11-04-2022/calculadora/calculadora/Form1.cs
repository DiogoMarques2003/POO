using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora {
    public partial class Form1 : Form {

        Calculadora calculadora = new Calculadora();

        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            calculadora.setNum1(Convert.ToInt32(textBox1.Text));
            calculadora.setNum2(Convert.ToInt32(textBox2.Text));

            label4.Text = calculadora.subtrair().ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            calculadora.setNum1(Convert.ToInt32(textBox1.Text));
            calculadora.setNum2(Convert.ToInt32(textBox2.Text));

            label4.Text = calculadora.multiplicar().ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            calculadora.setNum1(Convert.ToInt32(textBox1.Text));
            calculadora.setNum2(Convert.ToInt32(textBox2.Text));

            label4.Text = calculadora.dividir().ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            calculadora.setNum1(Convert.ToInt32(textBox1.Text));
            calculadora.setNum2(Convert.ToInt32(textBox2.Text));

            label4.Text = calculadora.soma().ToString();
        }
    }
}
