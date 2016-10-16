using System.Collections.Generic;
using System.Diagnostics;
using System;

namespace Vsite.CSharp
{
    class ForeachVsFor
    {
        static double ZbrojiUForPetlji(IList<double> kolekcija)
        {
            double zbroj = 0;
            for (int i = 0; i < kolekcija.Count; ++i)
                zbroj += kolekcija[i];
            return zbroj;
        }

        static double ZbrojiUForEachPetlji(IEnumerable<double> kolekcija)
        {
            double zbroj = 0;
            foreach (double broj in kolekcija)
                zbroj += broj;
            return zbroj;
        }

        static void Main(string[] args)
        {
            Random generatorSlučajnih = new Random();

            int brojElemenata = 200000;
            // prvo generiramo polje brojeva i popunimo ga
            double[] brojevi = new double[brojElemenata];
            for (int i = 0; i < brojElemenata; ++i)
                brojevi[i] = generatorSlučajnih.NextDouble();

            ZbrojiUForEachPetlji(brojevi);
            ZbrojiUForPetlji(brojevi);

            Console.Write("Niz obilazimo foreach: ");

            // štoperica će mjeriti vrijeme potrebno za prolaz kroz sve elemente 
            Stopwatch stoperica = new Stopwatch();
            stoperica.Start();

            ZbrojiUForEachPetlji(brojevi);

            stoperica.Stop();
            Console.WriteLine(stoperica.ElapsedTicks);
            Console.Write("Niz obilazimo for:     ");

            stoperica.Restart();

            ZbrojiUForPetlji(brojevi);

            stoperica.Stop();
            Console.WriteLine(stoperica.ElapsedTicks);


            List<double> listaBrojeva = new List<double>(brojevi);
            Console.Write("Listu obilazimo for:     ");
            stoperica.Restart();

            ZbrojiUForPetlji(listaBrojeva);

            stoperica.Stop();
            Console.WriteLine(stoperica.ElapsedTicks);

            Console.Write("Listu obilazimo foreach: ");
            stoperica.Restart();

            ZbrojiUForEachPetlji(listaBrojeva);

            stoperica.Stop();
            Console.WriteLine(stoperica.ElapsedTicks);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

        }
    }
}
