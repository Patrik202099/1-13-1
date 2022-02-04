using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szorzoTabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int elsoSzam, masodikSzam;

            Console.WriteLine("Helló!");

            Console.WriteLine("Add meg az első számot:");
            elsoSzam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a második számot:");
            masodikSzam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(elsoSzam*masodikSzam);
            Console.ReadKey();
        }
    }
}
