using System;

namespace Vsite.CSharp
{
    public class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            // TODO: Napisati petlju for koja će ispisati brojeve od 0 do n
        }

        public static void PetljaWhile(int n)
        {
            // TODO: Napisati petlju while koja će ispisati brojeve od 0 do n
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            // TODO: Prevesti program te programom ILDasm pogledati međukod. Međukodove metoda PetljaFor i PetljaWhile kopirati u datoteke "Petlja for.txt", odnosno "Petlja while.txt" koje su dio projekta

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
