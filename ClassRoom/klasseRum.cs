using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string Klassenavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            
        }

        public void SeasonCount()
        {
            int numberofSpring = 0;
            int numberofSummer = 0;
            int numberofAutumn = 0;
            int numberofVinter = 0;

            foreach (var student in Klasseliste)
            {
                switch (student.Fødselsmåned)
                {
                    case 3:
                    case 4:
                    case 5:
                        numberofSpring++;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        numberofSummer++;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        numberofAutumn++;
                        break;
                    case 12:
                    case 1:
                    case 2:
                        numberofVinter++;
                        break;
                        default: throw new ArgumentException("Sæson eksisterer ikke");
                        
                }
            }

            Console.WriteLine($"Antallet af elever der har fødselsdag i hver sin sæson er: {numberofSpring} elever om foråret, {numberofSummer} elever om summeren, {numberofAutumn} elever om efteråret og {numberofVinter} elever om vinteren");
        }
    }
}
