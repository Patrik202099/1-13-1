using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercekEsOrak
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan elso = new TimeSpan();
            TimeSpan masodik = new TimeSpan();

            Console.WriteLine("Első időpont: ");
            elso = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Második időpont: ");
            masodik = TimeSpan.Parse(Console.ReadLine());

            if (elso > masodik)
            {
                Console.WriteLine("A két időpont közötti különbség: " + (elso - masodik));
            }

            else if (masodik > elso)
            {
                Console.WriteLine("A két időpont közötti különbség: " + (masodik - elso));
            }

            Console.ReadKey();
        }
    }
}
