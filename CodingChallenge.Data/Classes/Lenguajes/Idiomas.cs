using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Lenguajes
{
    public class Idiomas
    {
        public static Tuple<int, string, string>[] Lenguajes = new Tuple<int, string, string>[] {
            Tuple.Create(0, "es-AR", "Español - Argentina"),
            Tuple.Create(1, "en-US", "English - United States"),
            Tuple.Create(2, "it-IT", "Italiano - Italia"),
            Tuple.Create(3, "fr-FR", "Francés - Francia")
        };
    }
}
