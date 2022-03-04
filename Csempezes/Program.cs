using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csaempezes
{
    class Program
    {
        static void Main(string[] args)
        {
           double teruletSzelesseg,
                  magassag,
                  szukseges,
                  csempe = 0.2 * 0.2;

            Console.WriteLine("Terület szélessége: ");
            teruletSzelesseg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Magasság méterben: ");
            magassag = Convert.ToDouble(Console.ReadLine());

            szukseges = (teruletSzelesseg * magassag) / csempe;

            Console.WriteLine(szukseges + szukseges * 0.1 + " darab csempe szükséges.");

            Console.ReadKey();
            
        }
    }
}
