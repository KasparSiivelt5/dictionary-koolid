using System;
using System.Collections.Generic;

namespace KooliNimed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kooliNimed = new Dictionary<int, string>();

            kooliNimed.Add(1, "Tallinna Tööstuhariduskeskus");
            kooliNimed.Add(2, "Tallinna Tehnikagümnaasium");
            kooliNimed.Add(3, "TalTech");

            foreach (KeyValuePair<int, string> kvp in kooliNimed)
            {
                Console.WriteLine("Kooli number: {0}, Kooli nimi: {1}", kvp.Key, kvp.Value);
            }

            Console.ReadKey();
        }
    }
}
