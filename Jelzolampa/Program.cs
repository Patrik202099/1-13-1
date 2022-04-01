using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jelzolampa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool idotartMegf = true;
            TimeSpan jelenIdo = new TimeSpan();
            TimeSpan megengedettIdo = new TimeSpan(22,00,00);
            // 22:00-után a lámpa 1.5 másodpercenként sárgán villant egyet
            // 3mp zöld, 3mp sárga, 5mp piros, 2mp piros - sárga, majd elölről.

            Console.WriteLine("Jelenlegi idő?: ");
            jelenIdo = TimeSpan.Parse(Console.ReadLine());

            if (jelenIdo >= megengedettIdo) { idotartMegf = false; }
            else { idotartMegf = true; }

            do
            {

                Console.WriteLine("PIROS!");
                Thread.Sleep(5000);
                Console.WriteLine("SÁRGA!");
                Thread.Sleep(3000);
                Console.WriteLine("ZÖLD!");
                Thread.Sleep(3000);
                Console.WriteLine("SÁRGA!");
                Thread.Sleep(1500);

            }
            while (idotartMegf == true);
            
            while (idotartMegf == false)

            {
                Console.WriteLine("SÁRGA!");
                Thread.Sleep(1500);
            }

            Console.ReadKey();
        }
    }
}
