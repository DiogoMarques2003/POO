using System;

namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase1 = "Olá mundo.", frase2 = "Bem-vindos ao c#.";

            Console.WriteLine("Frase 1: {0}", frase1);
            Console.WriteLine("Frase 2: {0}\n", frase2);

            Console.WriteLine("Comprimento da frase 1: {0}\nComprimento da frase 2: {1}", frase1.Length, frase2.Length);
            Console.WriteLine("Frase 1 mais frase 2: {0}", frase1 + " " + frase2);
            Console.WriteLine("Frase 1 em letras maiúsculas: {0}", frase1.ToUpper());
            Console.WriteLine("Subcadeia de caracteres da frase 1: {0}", frase1[..7]);
            Console.WriteLine("Posição de inicio da subcadeia de caracteres: {0}", frase2.IndexOf('v'));
            Console.WriteLine("Comparação da frase1 com a frase2: {0}", String.Equals(frase1, frase2) ? "iguais" : "diferentes");
            Console.WriteLine("Eliminar os espaços à esquerda e direita da frase 1: {0}", frase1.Trim());
        }
    }
}
