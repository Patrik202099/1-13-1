using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermeszetesSzamok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int paratlan = 0;
            int paros = 0;
            int paratlanOssz = 0;
            int N = rnd.Next(5, 11);
            int beker;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Add meg a számokat: ");
                beker = Convert.ToInt32(Console.ReadLine());

                if (beker % 2 == 0)
                {
                    paros++;
                }
                
                else if (beker % 2 != 0)
                {
                    paratlan++;
                    paratlanOssz = paratlanOssz + beker;
                }
            }

            Console.WriteLine("A generált számokban {0} páros és {1} páratlan szám van.", paros, paratlan);
            Console.WriteLine("A páratlan összegek száma: {0}", paratlanOssz);
            Console.ReadKey();
        }
    }
}
