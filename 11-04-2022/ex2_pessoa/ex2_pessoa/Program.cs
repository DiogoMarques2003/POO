using System;

namespace ex2_pessoa {
    internal class Program {
        static void Main(string[] args) {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa("João Silva");
            Pessoa pessoa3 = new Pessoa(18);
            Pessoa pessoa4 = new Pessoa("João Silva", 18);

            pessoa1.verInfo();
            pessoa2.verInfo();
            pessoa3.verInfo();
            pessoa4.verInfo();
        }
    }
}
