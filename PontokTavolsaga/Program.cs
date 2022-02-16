using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontokTavolsaga
{
    class Program
    {
        static void Main(string[] args)
        {

            float x1, x2, y1, y2, eredmeny;

            Console.WriteLine("Helló!");

            Console.WriteLine("Add meg az X1-et.");
            x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az X2-et.");
            x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az Y1-et.");
            y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az Y2-et.");
            y2 = float.Parse(Console.ReadLine());

           
            Console.WriteLine("A pontok távolsága: " + Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
            Console.ReadKey();
        }
    }
}
