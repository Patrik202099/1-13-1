using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeletlenSzamokListaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int min,
                max,
                menny = 0,
                veletlen;

            Console.WriteLine("Első érték: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Második érték: ");
            max = Convert.ToInt32(Console.ReadLine());

            
            
            while (menny < 3)
            {
                veletlen = random.Next(min, max);
                menny++;
                Console.WriteLine("\n" + veletlen);
            }


            Console.ReadKey();
        }
    }
}
