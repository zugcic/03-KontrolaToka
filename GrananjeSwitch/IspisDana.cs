using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    public static class IspisDana
    {
        public static string ImeDana(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // TODO: Dopisati grane case za svaki dan u tjednu (DayOfWeek.Tuesday = Utorak, itd.)
                case DayOfWeek.Monday:
                    return "ponedjeljak";

                default:
                    throw new ArgumentOutOfRangeException(nameof(danUTjednu));
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // TODO: Dopisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
                case DayOfWeek.Monday:
                    return "radni dan";

                default:
                    throw new ArgumentOutOfRangeException(nameof(danUTjednu));
            }
        }
    }
}
