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
            int kulonbseg; 

            for (int i = 0; i < sorSzamok.Length; i++)
			{
                Console.WriteLine("Szám: ");
                sorSzamok[i] = Convert.ToInt32(Console.ReadLine());
                kulonbseg = sorSzamok[3] - sorSzamok[2];

                if ()
                {
                    Console.WriteLine("Számtani sorozat.");
                }
                /* else if (sorSzamok[3] % sorSzamok[2] == sorSzamok[2] % sorSzamok[1])
                {
                    Console.WriteLine("Mértani sorozat.");
                } */
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
