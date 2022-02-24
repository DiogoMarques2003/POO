using System;

namespace ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal: {0}", 2500);
            Console.WriteLine("Scientific: {0:E}", 0.78876);
            Console.WriteLine("Fixed point: {0:F2}", 0.78876);
            Console.WriteLine("General: {0}", 2500);
            Console.WriteLine("Round Trip: {0:R}", 0.78876);
            Console.WriteLine("Number: {0:N}", 2500);
            Console.WriteLine("Percent: {0:P}", 0.78876);
            Console.WriteLine("Hexadecimal: {0:X}", 2500);
        }
    }
}
