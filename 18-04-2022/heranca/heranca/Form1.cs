using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heranca {
    public partial class Form1 : Form {

        Aluno aluno = new Aluno();
        Professor professor = new Professor();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //aluno
            aluno.Nome = "Diogo";
            aluno.Idade = 18;
            aluno.Morada = "Braga";
            aluno.Curso = "TII";
            aluno.Semestre = "2";
            label1.Text = aluno.ToString();

            //Professor
            professor.Nome = "Diogo";
            professor.Idade = 18;
            professor.Morada = "Braga";
            professor.Titulo = "Dev";
            professor.Especialidade = "Programação";
            professor.Salario = 1000.2;
            label2.Text = professor.ToString();
        }
    }
}
