using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szuletetett
{
    class Program
    {
        static void Main(string[] args)
        {
            string nev,
                   foglalkozas;
            char nem;
            int luckyNum;

            Random rnd = new Random();

            luckyNum = rnd.Next(1, 51);

            Console.WriteLine("Add meg a nevet: ");
            nev = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Add meg a foglalkozást: ");
            foglalkozas = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Add meg a nemet: (f/n)");
            nem = Convert.ToChar(Console.ReadLine());

            if (nem == 'f')
            {
                Console.WriteLine(nev + " egy " + foglalkozas + " férfi" + " volt, szerencse száma a " + luckyNum);
            }

            else if (nem == 'n')
            {
                Console.WriteLine(nev + " egy " + foglalkozas + " nő" + " volt, szerencse száma a " + luckyNum);
            }

            Console.ReadKey();
        }
    }
}
