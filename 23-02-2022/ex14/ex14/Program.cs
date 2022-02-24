using System;

namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "99";

            int i = Convert.ToInt32(s);
            i += 1;

            string x = Convert.ToString(i);

            Console.WriteLine(x + " tem " + x.Length + " dígitos");
        }
    }
}
