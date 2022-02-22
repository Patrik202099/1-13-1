using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelyikNagyobb
{
    class Program
    {
        static void Main(string[] args)
        {
            int elsoSzam,
                masodikSzam;

            Console.WriteLine("Első szám: ");
            elsoSzam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Második szám: ");
            masodikSzam = Convert.ToInt32(Console.ReadLine());

            if (elsoSzam > masodikSzam)
            {
                Console.WriteLine(elsoSzam + " nagyobb mint " + masodikSzam);
            }

            else if (masodikSzam > elsoSzam)
            {
                Console.WriteLine(masodikSzam + " nagyobb mint " + elsoSzam);
            }

            while (elsoSzam == masodikSzam)
            {
                Console.WriteLine("A két szám nem egyezhet meg.");

                Console.WriteLine("Első szám: ");
                elsoSzam = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Második szám: ");
                masodikSzam = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
