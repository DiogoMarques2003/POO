using System;

namespace ex2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ex 2:");

            double altura, baseT, ampliacao;

            Console.Write("Introduza a altura do triângulo: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Introduza a base do triângulo: ");
            baseT = double.Parse(Console.ReadLine());

            Console.Write("Introduza a ampliação que deseja fazer: ");
            ampliacao = double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(ampliacao, baseT);

            double[] medidasAmpliadas = triangulo.Ampliacao(ampliacao);

            Console.WriteLine("Área do triangulo: {0}.\nBase: {1}; Altura: {2}.\nAmpliação usada: {3}.\nAltura Ampliada: {4}; Base Ampliada: {5}", triangulo.Area(), triangulo.BaseT, triangulo.Altura, ampliacao, medidasAmpliadas[0], medidasAmpliadas[1]);
        }
    }
}
