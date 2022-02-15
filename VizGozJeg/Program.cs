using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizGozJeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int homerseklet;
            // Halmaz: folyékony, gőz, jég

            Console.WriteLine("Víz-Gőz-Jég!");

            Console.WriteLine("Add meg a víz hőmérsékletét!: ");
            homerseklet = Convert.ToInt32(Console.ReadLine());

            if (homerseklet < 0)
            {
                Console.WriteLine("Jég halmazállapotú.");

            }

            else if (homerseklet >= 0 && homerseklet < 100)
            {
                Console.WriteLine("Folyékony halmazállapotú.");
            }

            else if (homerseklet >= 100)
            {
                Console.WriteLine("Gőz halmazállapotú.");
            }    

            Console.ReadKey();
        }
    }
}
