using System;

namespace Vsite.CSharp
{
    class PetljeWhileDoWhile
    {
        static void Main(string[] args)
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva

            int brojBacanja = 0;
            // TODO: Napisati simulaciju početka igre "Čovječe ne ljuti se": kocka se baca sve dok ne padne na 6

            {
                ++brojBacanja;
                int slučajniBroj = generatorSlučajnih.Next(1, 6); // generira slučajni broj između 1 i 6
                Console.WriteLine("{0}. pokušaj: {1}", brojBacanja, slučajniBroj);
            }

            int brojPređenihPolja = brojBacanja;
            // TODO: Napisati petlju u kojoj se kocka baca sve dok brojPređenihPolja ne postane veći od 12

            {
                int slučajniBroj = generatorSlučajnih.Next(1, 6); // generira slučajni broj između 1 i 6
                Console.WriteLine("{0} + {1}", brojPređenihPolja + slučajniBroj);
                brojPređenihPolja += slučajniBroj;
            }

            Console.WriteLine("Zbroj = {0}", brojPređenihPolja);

            Console.ReadKey();

            // TODO: pokrenite program, provjerite njegovu ispravnost i ispis prekopirajte u datoteku "PetljeWhileDoWhile.txt" koja je pridružena ovom projektu
        }

    }
}
