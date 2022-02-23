using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbElemBekerese
{
    class Program
    {
        static void Main(string[] args)
        {
            int szamOsszeg = 0,
                beker,
                paratlan = 0,
                paros = 0;

            while (szamOsszeg < 100)
            {
                Console.WriteLine("Adj meg egy számot!: ");
                beker = Convert.ToInt32(Console.ReadLine());
                szamOsszeg = szamOsszeg + beker;

                if (beker % 2 == 0)
                {
                    paros++;
                }
                
                else if (beker % 2 != 0)
                {
                    paratlan++;
                }
            }
            if (szamOsszeg >= 100)
            {
                Console.WriteLine("A bekért számok közül {0} páros és {1} páratlan volt.", paros, paratlan);
            }
            Console.ReadKey();
        }
    }
}
