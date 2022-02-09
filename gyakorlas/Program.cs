using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            string beker;
            int homerseklet;

            Console.WriteLine("Adj meg egy hőmérsékletet.");
            homerseklet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Celsiusból - Fahrenheitbe, vagy Fahrenheitből - Celsiusba váltanál? (e / m) ");
            
            switch (Console.ReadKey(true).KeyChar)
            {
                case 'e':
                    Console.WriteLine(homerseklet + " celsius pontosan");
                    break;
            }


            Console.ReadKey();
        }
    }
}
