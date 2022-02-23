using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyv
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldalszam;
            string konyvcim;
            bool terjedelem;

            Console.WriteLine("Add meg a könyv címét: ");
            konyvcim = Convert.ToString(Console.ReadLine());

            while (string.IsNullOrEmpty(konyvcim))
            {
                Console.WriteLine("Add meg a könyv címét: ");
                konyvcim = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("Add meg az oldalak számát: ");
            oldalszam = Convert.ToInt32(Console.ReadLine());

            if (oldalszam > 150)
            {
                terjedelem = true;
                Console.WriteLine("A/az " + konyvcim + " egy hosszú terjedelmű könyv.");
            }

            else if (oldalszam <= 150)
            {
                terjedelem = false;
                Console.WriteLine("A/az " + konyvcim + " egy rövid terjedelmű könyv.");

            }
            Console.ReadKey();
        }
    }
}
