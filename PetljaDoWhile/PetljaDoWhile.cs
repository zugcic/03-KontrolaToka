using System;

namespace Vsite.CSharp
{
    class PetljaDoWhile
    {
        static void Main(string[] args)
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva

            int zbroj = 0;
            // TODO: napišite petlju u kojoj se varijabli zbroj dodaju slučajno generirani brojevi samo dok je zbroj manji od 42

            {
                int slučajniBroj = generatorSlučajnih.Next(2, 15); // generira slučajni broj između 2 i 14
                Console.WriteLine("{0} + {1}", zbroj + slučajniBroj);
                zbroj += slučajniBroj;
            }

            Console.WriteLine("Prvi zbroj = {0}", zbroj);

            zbroj = 0;
            // TODO: napišite petlju u kojoj se varijabli zbroj dodaju slučajno generirani brojevi sve dok zbroj ne postane veći od 42

            {
                int slučajniBroj = generatorSlučajnih.Next(2, 15); // generira slučajni broj između 2 i 14
                Console.WriteLine("{0} + {1}", zbroj + slučajniBroj);
                zbroj += slučajniBroj;
            }

            Console.WriteLine("Drugi zbroj = {0}", zbroj);

            Console.ReadKey();

            // TODO: pokrenite program, provjerite njegovu ispravnost i ispis prekopirajte u datoteku "PetljaDoWhile.txt" koja je pridružena ovom projektu
        }
    }
}
