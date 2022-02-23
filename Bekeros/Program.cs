using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bekeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamLista = new List<int>();
            int beker;

            Console.WriteLine("Adj meg egy egész számot: ");
            beker = Convert.ToInt32(Console.ReadLine());

            while (beker != 0)
            {
                Console.WriteLine("Adj meg egy egész számot: ");
                beker = Convert.ToInt32(Console.ReadLine());
                szamLista.Add(beker);
            }
            Console.WriteLine(szamLista);
            Console.ReadKey();
        }
    }
}
