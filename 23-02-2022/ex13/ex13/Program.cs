using System;

namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal d = 99.56M;
            int i = (int)d;

            Console.WriteLine(d + " e " + i);

            i = 100;
            d = i;

            Console.WriteLine(d + " e " + i);
        }
    }
}
