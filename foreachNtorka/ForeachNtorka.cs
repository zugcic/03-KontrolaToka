using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var osoba = new Tuple<string, string, DateTime>("Šegrt", "hlapić", DateTime.Parse("1893-12-01"));
            foreach (var stavka in osoba)
                Console.WriteLine(stavka);

            Console.ReadKey();
        }
    }
}
