using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Homerseklet
    {
        // minden napra egy legkisebb - legnagyobb érték
        Random rnd = new Random();
        
        public void NapiHoGeneral()
        {
            for (int n = 1; n <= 30; n++)
            {
                rnd.Next(tart);
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int tart1, tart2;

            Dictionary<string, int> honap = new Dictionary<string, int>
            {
                {"Január", 1}, {"Febuár", 2 }, {"Március", 3 },
                {"Április", 4 }, {"Május", 5}, {"Június", 6 },
                {"Július", 7}, {"Augusztus", 8 }, {"Szeptember", 9 },
                {"Október", 10 }, {"November", 11 }, {"December", 12 }

            };

            Console.WriteLine("Hónap?: ");
            int evszak = honap[Console.ReadLine()];

            if (evszak >= 3 && evszak <= 5)
            {

            }
            if (evszak >= 3 && evszak <= 5)
                Console.ReadKey();
        }
    }
}
