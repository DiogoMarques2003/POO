using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1 {
    internal class Pessoa {
        private string nome;
        private string sexo;
        private int idade;

        private int contadorRaparigas;
        private int contadorRapazes;
        private int contadorMulheres;
        private int contadorHomens;

        public Pessoa() {
            this.contadorHomens = 0;
            this.contadorMulheres = 0;
            this.contadorRaparigas = 0;
            this.contadorRapazes = 0;
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public string Sexo {
            get { return sexo; }
            set { sexo = value; }
        }

        public int Idade {
            get { return idade; }
            set { idade = value; }
        }

        public void classificarPessoa() {
            if (this.idade < 18) {
                if (this.sexo.ToLower() == "m") this.contadorRapazes++;
                else this.contadorRaparigas++;
            } else {
                if (this.sexo.ToLower() == "m") this.contadorHomens++;
                else this.contadorMulheres++;
            }
        }

        public int[] devolveContadores() {
            int[] devolveContadores = { contadorHomens, contadorMulheres, contadorRapazes, contadorRaparigas };
            return devolveContadores;
        }

        public static void mostrarContadores(int[] contadores) {
            Console.WriteLine("Contadores: ");
            Console.WriteLine("Homens: {0}\nMulheres: {1}\nRapazes: {2}\nRaparigas: {3}", contadores[0], contadores[1], contadores[2], contadores[3]);
        }
    }
}
