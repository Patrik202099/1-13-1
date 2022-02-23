using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negativ
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

            if (elsoSzam < 0 && masodikSzam < 0)
            {
                Console.WriteLine("Mind a két szám negatív!");
            }

            else if (elsoSzam < 0 )
            {
                Console.WriteLine("Az első szám negatív!");
            }

            else if (masodikSzam < 0)
            {
                Console.WriteLine("A második szám negatív!");
            }

            else 
            {
                Console.WriteLine("Egyik szám sem negatív!");
            }
                        
            Console.ReadKey();
        }
    }
}
