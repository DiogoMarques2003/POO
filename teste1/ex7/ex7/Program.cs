using System;

namespace ex7 {
    internal class Program {
        static void Main(string[] args) {
            int[] meses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] nomeMes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int mes;

            Console.Write("Introduza o número do mês: ");
            mes = Convert.ToInt32(Console.ReadLine());
            while (mes < 1 || mes > 12) {
                Console.WriteLine("Mês inválido, introduza novamente: ");
                mes = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("O mês {0}({1}) tem {2} dias", nomeMes[mes - 1], mes, meses[mes - 1]);
        }
    }
}
