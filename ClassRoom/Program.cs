using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasseRum = new KlasseRum();
            klasseRum.Klassenavn = "3B";
            klasseRum.SemesterStart = new DateTime(4/9/2018);
            klasseRum.Klasseliste = new List<Studerende>{new Studerende("Frederik", 2,2), new Studerende("Louis", 3, 3), new Studerende("Vagner", 5, 6)};

        }
    }
}
