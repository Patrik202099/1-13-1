using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masofoku
{
    class Program
    {
        static void Main(string[] args)
        {
            float a,
                  b,
                  c;

            float valosgyok;
            
            Console.WriteLine("A: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("B: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("C: ");
            c = float.Parse(Console.ReadLine());

            valosgyok = (b * b - 4 * a * c);
            Console.WriteLine("Valós gyök: " + valosgyok);

            Console.ReadKey();
        }
    }
}
