using System;

namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f = 345.3456F;
            double d = 6.89765432127865;
            decimal de = 1234567897654300.14567896543M;

            Console.WriteLine(f + " < " + d + " < " + de);
        }
    }
}
