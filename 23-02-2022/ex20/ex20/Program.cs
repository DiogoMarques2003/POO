using System;

namespace ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario = 1000,
                vendas = 100,
                capital = 1000,
                aumento = 10,
                factorJuros = 1.05F,
                iva = 20;

            Console.WriteLine("Salário depois do aumento: {0}", salario+aumento);
            Console.WriteLine("Vendas líquidas: {0}", vendas-(vendas*iva)/100);
            Console.WriteLine("Capital acumulado: {0}", capital*factorJuros);
            Console.WriteLine("Resto da divisão de 10 por 3: {0}", 10 % 3);
        }
    }
}
