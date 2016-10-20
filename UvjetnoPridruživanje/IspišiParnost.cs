using System;

namespace Vsite.CSharp
{
    public static class IspišiParnost
    {
        public static void UvjetnimPridruživanjem(int broj)
        {
            
            string odgovor = broj%2==0 ? "paran": "neparan"; //uvjetno pridruživanje-> uvjet?a ko je: ako nije;

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }

        public static void GrananjemIf(int broj)
        {
            // TODO: Korištenjem grananja if dodijeliti varijabli odgovor vrijednost 
            // "paran" ili "neparan" ovisno o djeljivosti zadanog broja
            string odgovor = "neparan";
            if (broj % 2 == 0)
            {
                odgovor = "paran";
            }

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }
    }
}
