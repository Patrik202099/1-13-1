using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menupontok
{
    class Program
    {
        static void Main(string[] args)
        {
            int valasztas;

            Console.WriteLine("1 Első menüpont");
            Console.WriteLine("2 Második menüpont");
            Console.WriteLine("3 Harmadik menüpont");
            Console.WriteLine("4 Negyedik menüpont");
            Console.WriteLine("5 Kilépés");

            Console.WriteLine("Válassz egy menüpontot: ");
            valasztas = Convert.ToInt32(Console.ReadLine());

            switch (valasztas)
            {
                case 1:
                    Console.WriteLine("Az első menüpontot választottad.");
                    break;

                case 2:
                    Console.WriteLine("A második menüpontot választottad.");
                    break;

                case 3:
                    Console.WriteLine("A harmadik menüpontot választottad.");
                    break;

                case 4:
                    Console.WriteLine("A negyedik menüpontot választottad.");
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Rossz választás");
                    break;
            }
            Console.ReadKey();
        }
    }
}
