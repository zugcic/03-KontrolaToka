using System;

namespace Vsite.CSharp
{
    public class DosegImena
    {
        static void Main(string[] args)
        {
            DosegImena p = new DosegImena();
            p.IspišiAove();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public void IspišiAove()
        {
            string a = "Lokalna varijabla";

            Console.WriteLine(a); // ispis lokalne varijable a

            Console.WriteLine(this.a); //ipsis člana klase

            {

                //int a = 5;//C# ne dozovoljava definiranje isog naziva varijabli unutar bloka
                

            }
        }

        string a = "Član klase";
    }
}
