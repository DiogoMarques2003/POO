using System;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4==5: {0}", 4==5);
            Console.WriteLine("4!=6: {0}", 4!=6);
            Console.WriteLine("4>5: {0}", 4>5);
            Console.WriteLine("4<5 e 6>10: {0}", 4<5 && 6>10);
            Console.WriteLine("40<50 ou 60>90: {0}", 40<50 || 60>90);
            Console.WriteLine("Não(40<50 ou 60>90): {0}", !(40 < 50 || 60 > 90));
        }
    }
}
