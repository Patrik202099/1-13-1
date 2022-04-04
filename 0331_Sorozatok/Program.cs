using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0331_Sorozatok
{
    class Sorozatok
    {
        public void SorVizsgal()
        {
            int [] sorSzamok = new int[4];
            int diff; 

            for (int i = 0; i < sorSzamok.Length; i++)
			{
                Console.WriteLine("Szám: ");
                sorSzamok[i] = Convert.ToInt32(Console.ReadLine());
                diff = sorSzamok[1] - sorSzamok[0];

                if (sorSzamok[1] - sorSzamok[0] == diff && sorSzamok[3] - sorSzamok[2] == diff)
                {
                    Console.WriteLine("A sorozat differenciálja: {0}", diff);
                    Console.WriteLine("Számtani sorozatról beszélünk.");
                }
                else if (sorSzamok[1] / sorSzamok[0] == diff && sorSzamok[3] / sorSzamok[2] == diff)
                {
                    Console.WriteLine("A sorozat differenciálja: {0}", diff);
                    Console.WriteLine("Mértani sorozatról beszélünk.");
                }
			}

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Sorozatok sor = new Sorozatok();
            sor.SorVizsgal();
            Console.ReadKey();
        }
    }
}
