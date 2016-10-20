using System;

namespace Vsite.CSharp
{
    public class GranjanjeIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši neki cijeli broj:");
            string unos = Console.ReadLine();

            try
            {
                int broj = int.Parse(unos);
                ProvjeriDjeljivost(broj);

                Console.WriteLine("GOTOVO!");
            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos, pokušaj ponovo.");
            }

            Console.ReadKey();
        }

        public static void ProvjeriDjeljivost(int broj)
        {
           
            if (broj % 2 == 0) //djeljiv sa 2
            {
                Console.WriteLine("broj je djeljiv s 2");
            }
            else if (broj % 3 == 0) //djeljiv sa 3
            {
                Console.WriteLine("broj je djeljiv s 3");
            }
            else if (broj % 5 == 0) //djeljiv sa 5
            {
                Console.WriteLine("broj je djeljiv s 5");
            }
            else {          //nije djeljiv ni sa 2,3,5
                Console.WriteLine("broj nije djeljiv s 2, 3 niti 5");
            }
           
        }
    }
}
