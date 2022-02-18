using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlapvetoMuveletek
{
    class Program
    {
        static void Main(string[] args)
        {
            float elsoSzam,
                masodikSzam;

            Console.WriteLine("Első szám: ");
            elsoSzam = float.Parse(Console.ReadLine());

            Console.WriteLine("Második szám: ");
            masodikSzam = float.Parse(Console.ReadLine());

            Console.WriteLine("A két szám összege: {0}", elsoSzam + masodikSzam);
            Console.WriteLine("A két szám különbsége: {0}", elsoSzam - masodikSzam);
            Console.WriteLine("A két szám szorzata: {0}", elsoSzam * masodikSzam);
            Console.WriteLine("A két szám hányadosa: {0}", elsoSzam / masodikSzam);
            Console.ReadKey();
        }
    }
}
