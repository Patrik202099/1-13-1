using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szokozok
{
    class Program
    {
        static void Main(string[] args)
        {
            string mondat;

            Console.WriteLine("Írj egy mondatot: ");
            mondat = Convert.ToString(Console.ReadLine());

            Console.WriteLine(String.Concat(mondat.Where(c => !Char.IsWhiteSpace(c))));
            Console.ReadKey();
        }
    }
}
