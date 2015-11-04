using System;

namespace Vsite.CSharp
{
    class UsporedbeRealnihBrojeva
    {
        static void Main(string[] args)
        {
            double tri = 3.0;

            // TODO: provjeriti što će ispisati donja usporedba te popraviti ispitivanja da se dobije očekivani rezultat
            if ((1.0 - 1.0 / tri) == (2.0 / tri))
                Console.WriteLine("1 - 1/3 jednako je 2/3");
            else
                Console.WriteLine("1 - 1/3 nije jednako 2/3!");

            // TODO: provjeriti što će ispisati donja usporedba te popraviti ispitivanja da se dobije očekivani rezultat
            if (tri * 0.1 == 0.3)
                Console.WriteLine("3 * 0.1 je jednako 0.3");
            else
                Console.WriteLine("3 * 0.1 nije jednako 0.3!");
            Console.ReadKey();
        }
    }
}
