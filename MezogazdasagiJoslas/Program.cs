using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezogazdasagiJoslas
{
    class Program
    {
        static void Main(string[] args)
        {
            float buza;
            int szorzo;
            string hozam = "";

            Random rnd = new Random();

            Console.WriteLine("Add meg az elvetett búza mennyiségét: ");
            buza = float.Parse(Console.ReadLine());
            szorzo = rnd.Next(5, 16);

            if (szorzo >= 5 && szorzo < 8)
            {
                hozam = "átlag alatti";
            }

            else if (szorzo >= 8 && szorzo < 12)
            {
                hozam = "átlagos";
            }

            else if (szorzo > 12)
            {
                hozam = "átlag feletti";
            }

            Console.WriteLine("A várható hozam, " + (buza * szorzo) + " mely " + hozam + "-nak felel meg.");
            Console.ReadKey();
        }
    }
}
