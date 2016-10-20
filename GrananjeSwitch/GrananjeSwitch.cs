﻿using System;
using System.Globalization;

namespace Vsite.CSharp
{
    class GrananjeSwitch
    {
        static void Main(string[] args)
        {
            CultureInfo kultura = new CultureInfo("hr");  //izabiremo na kojem jeziku će se ispisati
            string formatDatuma = kultura.DateTimeFormat.ShortDatePattern;

            Console.WriteLine("Unesite neki datum u obliku {0}", formatDatuma);
            string unos = Console.ReadLine();

            try
            {
                DateTime datum = DateTime.Parse(unos, kultura);
                DayOfWeek danUTjednu = datum.DayOfWeek;

                Console.WriteLine("Taj datum je {0}", IspisDana.ImeDana(danUTjednu));
                // ovo je jednostavniji način za ispis dana u tjednu!!!
                Console.WriteLine("Taj datum je {0}", datum.ToString("dddd", kultura));

                Console.WriteLine("Taj dan je {0}", IspisDana.RadniNeradni(danUTjednu));
            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos datuma!");
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
