using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgazolatlanHianyzas
{
    class Program
    {
        static void Main(string[] args)
        {
            int hianyzasok,
                szuletes;

            Console.WriteLine("Add meg az igazolatlan hiányzásaidat: ");
            hianyzasok = Convert.ToInt32(Console.ReadLine());

            if (hianyzasok >= 10)
            {
                Console.WriteLine("Add meg a születési dátumod: (EV/HONAP/NAP)");
                szuletes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Igazolatlan hiányzásaid száma: " + szuletes);
            }

            if (hiany)

            Console.ReadKey();
        }
    }
}
