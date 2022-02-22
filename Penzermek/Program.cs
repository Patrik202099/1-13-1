using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penzermek
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeg;

            Console.WriteLine("Add meg az összeget: ");
            osszeg = Convert.ToInt32(Console.ReadLine());

            int[] cimletek = { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5};
            int[] cimletDarab = new int[12];

            for (cimletDarab[0] = 0; osszeg >= 20000; cimletDarab[0]++)
            {
                osszeg = osszeg - 20000;
            }
            for (cimletDarab[1] = 0; osszeg >= 10000; cimletDarab[1]++)
            {
                osszeg = osszeg - 10000;
            }
            for (cimletDarab[2] = 0; osszeg >= 5000; cimletDarab[2]++)
            {
                osszeg = osszeg - 5000;
            }
            for (cimletDarab[3] = 0; osszeg > 2000; cimletDarab[3]++)
            {
                osszeg = osszeg - 2000;
            }
            for (cimletDarab[4] = 0; osszeg > 1000; cimletDarab[4]++)
            {
                osszeg = osszeg - 1000;
            }
            for (cimletDarab[5] = 0; osszeg > 500; cimletDarab[5]++)
            {
                osszeg = osszeg - 500;
            }
            for (cimletDarab[6] = 0; osszeg > 200; cimletDarab[6]++)
            {
                osszeg = osszeg - 200;
            }
            for (cimletDarab[7] = 0; osszeg > 100; cimletDarab[7]++)
            {
                osszeg = osszeg - 100;
            }
            for (cimletDarab[8] = 0; osszeg > 50; cimletDarab[8]++)
            {
                osszeg = osszeg - 50;
            }
            for (cimletDarab[9] = 0; osszeg > 20; cimletDarab[9]++)
            {
                osszeg = osszeg - 20;
            }
            for (cimletDarab[10] = 0; osszeg > 10; cimletDarab[10]++)
            {
                osszeg = osszeg - 10;
            }
            for (cimletDarab[11] = 0; osszeg > 5; cimletDarab[11]++)
            {
                osszeg = osszeg - 5;
            }

            Console.WriteLine("20000-esből: " + cimletDarab[0]);
            Console.WriteLine("10000-esből: " + cimletDarab[1]);
            Console.WriteLine("5000-esből: " + cimletDarab[2]);
            Console.WriteLine("2000-esből: " + cimletDarab[3]);
            Console.WriteLine("1000-esből: " + cimletDarab[4]);
            Console.WriteLine("500-asból: " + cimletDarab[5]);
            Console.WriteLine("200-asból: " + cimletDarab[6]);
            Console.WriteLine("100-asból: " + cimletDarab[7]);
            Console.WriteLine("50-esből: " + cimletDarab[8]);
            Console.WriteLine("20-asból: " + cimletDarab[9]);
            Console.WriteLine("10-esből: " + cimletDarab[10]);
            Console.WriteLine("5-ösből: " + cimletDarab[11]);




            Console.ReadKey();
        }
    }
}
