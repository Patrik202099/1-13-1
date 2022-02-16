using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontHatarok
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontszam;

            Console.WriteLine("Add meg a pontszámodat: ");
            pontszam = Convert.ToInt32(Console.ReadLine());

            if (pontszam < 50)
            {
                Console.WriteLine("1-es.");
            }

            else if (pontszam >= 50  && pontszam < 65)
            {
                Console.WriteLine("2-es.");
            }

            else if (pontszam >= 65 && pontszam < 80)
            {
                Console.WriteLine("3-as.");
            }

            else if (pontszam >= 80 && pontszam < 90)
            {
                Console.WriteLine("4-es.");
            }    

            else if (pontszam >= 90)
            {
                Console.WriteLine("5-ös.");
            }

            while (pontszam > 100 || pontszam < 0)
            {
                Console.WriteLine("Hibás adat, próbáld újra!");
                break;
            }

            Console.ReadKey();

        }
    }
}
