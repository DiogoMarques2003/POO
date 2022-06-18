using System;

namespace ex1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ex 1:");

            Professor professor = new Professor("Paulo Reis", 42, "Matemática", 314);
            Aluno aluno = new Aluno("Rui Pedro", 19, 20145, "Desenvolvimento de Solftware");

            Console.WriteLine("Professor :: {0}", professor.ToString());
            Console.WriteLine("Aluno :: {0}", aluno.ToString());

            Console.WriteLine("\nEx 2: ");

            Aluno[] alunos = new Aluno[3];

            alunos[0] = new Aluno("Ana", 23);
            alunos[1] = new Aluno("Rui", 22);
            alunos[2] = new Aluno("Sara", 19);

            Console.WriteLine("Alunos: ");
            for (int i = 0; i < alunos.Length; i++) {
                Console.WriteLine("{0}º Aluno :: {1}", i+1, alunos[i].ToString());
            }
        }
    }
}
