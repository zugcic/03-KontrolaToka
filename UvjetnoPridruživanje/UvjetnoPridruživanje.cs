using System;

namespace Vsite.CSharp
{
    public class UvjetnoPridruživanje
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši neki cijeli broj:");
            string unos = Console.ReadLine();

            try
            {
                int broj = int.Parse(unos);

                IspišiParnostUvjetnimPridruživanjem(broj);

                IspišiParnostIfGrananjem(broj);
            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos");
            }
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static void IspišiParnostUvjetnimPridruživanjem(int broj)
        {
            // TODO: Napisati uvjetno pridruživanje ?: koje će ovisno o dijeljivosti 
            // broja varijabli odgovor dodijeliti vrijednost "paran" ili "neparan"
            string odgovor = "neparan";

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }

        public static void IspišiParnostIfGrananjem(int broj)
        {
            // TODO: Korištenjem grananja if dodijeliti varijabli odgovor vrijednost 
            // "paran" ili "neparan" ovisno o djeljivosti zadanog broja
            string odgovor = "neparan";

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }
    }
}
