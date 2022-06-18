using System;

namespace ex4 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ex 4:");

            Livro[] livros = new Livro[3];

            livros[0] = new Livro("3 porquinhos", "pedro", 1999, "rui");
            livros[1] = new Livro("2 porquinhos", "pedro", 1800, "rui");
            livros[2] = new Livro("1 porquinhos", "pedro", 2000, "rui");

            Console.WriteLine("\nLivros:");
            for (int i = 0; i < livros.Length; i++) {
                livros[i].posteriorAno(1990);
            }

            Revista[] revistas = new Revista[3];

            revistas[0] = new Revista("3 porquinhos", "pedro", 1999, "ola", 1);
            revistas[1] = new Revista("2 porquinhos", "pedro", 1800, "ola", 2);
            revistas[2] = new Revista("1 porquinhos", "pedro", 2000, "ola", 3);

            Console.WriteLine("\nRevistas:");
            for (int i = 0; i < revistas.Length; i++) {
                revistas[i].posteriorAno(1990);
            }
        }
    }
}
