using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[5];
            int bekSzam;

            // Hozzáadás
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Számot: ");
                bekSzam = int.Parse(Console.ReadLine());
                szamok[i] = bekSzam;

            }

            // Fordított kiíratás

            for (int i = 5; i < szamok.Length; i--)
            {
                Console.WriteLine(szamok[i]);
            }
            
            Console.ReadKey();
        }
    }
}
