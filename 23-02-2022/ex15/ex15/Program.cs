using System;

namespace ex15
{
    internal class Program
    {
        enum Notas {
            E = 0,
            D = 8,
            C = 10,
            B = 14,
            A = 17
        }

        static void Main(string[] args) {
            Console.WriteLine("Distinção >= {0}", (int)Notas.A);
            Console.WriteLine("Aprovações >= {0}", (int)Notas.C);
            Console.WriteLine("Oral entre {0} e {1}", (int)Notas.D, (int)Notas.C);
            Console.WriteLine("Reprovados <= {0}", (int)Notas.D);
        }
    }
}
