using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_numbers_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[1000];
            int cnt = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                cnt++;
                Console.WriteLine("Szám: ");
                szamok[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Megadott számok értéke: {0}", szamok[i++]);
            }
            Console.ReadKey();

        }
    }
}
