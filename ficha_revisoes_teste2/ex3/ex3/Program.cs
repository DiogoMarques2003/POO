using System;

namespace ex3 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("EX 3:");

            Vinil vinil = new Vinil("Live From Mars", null, "Ben Harper & the Innocent Criminals", 2001, "LP");
            CD cd = new CD("Queen 40", null, "Queen", 2011, 30);
            DVD dvd = new DVD("Concerto em Lisboa", "Mariza", null, 2006, false);

            vinil.Play();
            cd.Play();
            dvd.Play();
        }
    }
}
