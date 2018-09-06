using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
        public string Navn { get; set; }
        public int Fødselsmåned { get; set; }
        public int Fødselsdag { get; set; }
        public string Season { get; set; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
            BirthSeason();
        }

        public string BirthSeason()
        {
            if (Fødselsmåned==12 || Fødselsmåned<3)
            {
                Season = "Vinter";
            }
            else if (Fødselsmåned<6 && Fødselsmåned>2)
            {
                Season = "Forår";
            }
            else if (Fødselsmåned<9 && Fødselsmåned>5)
            {
                Season = "Sommer";
            }
            else if (Fødselsmåned<12 && Fødselsmåned>8)
            {
                Season = "Efterår";
            }
            else if (Fødselsmåned>12)
            {
                Console.WriteLine("Fødselsmåned kan ikke være større end 12");
            }
            return Navn;
        }

        public override string ToString()
        {
            return Navn + ", " + Fødselsmåned + ", " + Fødselsdag + ", " + Season;
        }
    }
}
