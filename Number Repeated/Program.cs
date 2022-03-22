using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Repeated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int milyenSzam;
            int hanyszor;

            Console.WriteLine("Szám: ");
            milyenSzam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hányszor: ");
            hanyszor = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hanyszor; i++)
            {
                Console.Write(milyenSzam);
            }
            Console.ReadKey();
        }
    }
}
