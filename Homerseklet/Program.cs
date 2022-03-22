using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Homerseklet
    {
            Dictionary<string, int> honap = new Dictionary<string, int>
            {
                {"Január", 1},    {"Február", 2 },     {"Március", 3 },
                {"Április", 4 },  {"Május", 5},        {"Június", 6 },
                {"Július", 7},    {"Augusztus", 8 },   {"Szeptember", 9 },
                {"Október", 10 }, {"November", 11 },   {"December", 12 }

            Console.WriteLine("Hónap?: ");
            int evszak = honap[Console.ReadLine()];

            // Tavasz
            if (evszak >= 3 && evszak <= 5)
            {
                minMin = -10;
                minMax = -5;
                maxMin = 5;
                maxMax = 16;
            }
            // Nyár
            if (evszak >= 6 && evszak <= 8)
            {
                minMin = 7;
                minMax = 19;
                maxMin = 25;
                maxMax = 41;

            }   
            // Ősz
            if (evszak >= 9 && evszak <= 11)
            {   
                minMin = -6;
                minMax = -2;
                maxMin = 5;
                maxMax = 14;

            }
            // Tél
            if (evszak >= 12 && evszak <= 2)
            {
                minMin = -22;
                minMax = -5;
                maxMin = -2;
                maxMax = 6;
            }
            };
            int minMin = 0;
            int minMax = 0;
            int maxMin = 0;
            int maxMax = 0;
        
        Random rnd = new Random();
        
        public void NapiMinHomerseklet()
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
            Console.ReadKey();
        }
    }
}
