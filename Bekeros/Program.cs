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
            var szamLista = new List<int>();
            int beker;

            Console.WriteLine("Adj meg egy egész számot: ");
            beker = Convert.ToInt32(Console.ReadLine());

            while (beker != 0)
            {   
                szamLista.Add(beker);
                Console.WriteLine("Adj meg egy egész számot: ");
                beker = Convert.ToInt32(Console.ReadLine());             
            }
            szamLista.Sort();
            Console.WriteLine("A legnagyobb szám a listában: {0}", szamLista[szamLista.Count-1]);
            Console.ReadKey();
        }
    } 
}
