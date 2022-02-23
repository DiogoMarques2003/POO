using System;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte s = 34;
            byte b = 250;
            short sh = 32000;
            ushort u = 60000;
            int i = 1000000012;
            uint ui = 3500000000;
            long l = 1532333333334581239;
            ulong f = 14532333333334581239;

            Console.WriteLine(s + " < " + b + " < " + sh + " < " + u + " < " + i + " < " + ui + " < " + l + " < " + f);
        }
    }
}
