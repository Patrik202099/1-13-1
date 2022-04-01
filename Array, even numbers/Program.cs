using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array__even_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];

            // Feltöltés
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Szám: ");
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Eldöntés hogy páros - e, majd kiíratás.
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0) 

                { 
                    Console.WriteLine("Páros szám: {0}\n",szamok[i]); 
                }
            }
            Console.ReadKey();
        }
    }
}
