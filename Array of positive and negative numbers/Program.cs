using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_positive_and_negative_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozitivCnt = 0;
            int negativCnt = 0;
            float totalNegative = 0.0f;
            float totalPositive = 0.0f;
            float[] szamok = new float[10];

            // Listához ad
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Szám:");
                szamok[i] = float.Parse(Console.ReadLine());
            }

            // Eldöntés, majd átlag
            for (int i = 0; i < 10; i++)
            {
                if (szamok[i] < 0)
                {
                    totalNegative = +szamok[i];
                    negativCnt++;
                }
                else if (szamok[i] > 0)
                {
                    totalPositive = +szamok[i];
                    pozitivCnt++;
                }
            }
            Console.WriteLine("A negatív számok átlaga: {0}", totalNegative / negativCnt);
            Console.WriteLine("A pozitív számok átlaga: {0}", totalPositive / pozitivCnt);

            Console.ReadKey();
        }
    }
}
