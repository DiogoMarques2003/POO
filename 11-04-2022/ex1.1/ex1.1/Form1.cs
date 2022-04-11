using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1._1 {
    public partial class Form1 : Form {

        Lampada lampada = new Lampada();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            lampada.acender();
        }

        private void button2_Click(object sender, EventArgs e) {
            lampada.apagar();
        }

        private void button3_Click(object sender, EventArgs e) {
            label2.Text = lampada.estado();
        }
    }
}
