using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            string szamitoValaszt = "";
            string jatekosValaszt = "";

            int szamitoPont = 0;
            int jatekosPont = 0;

            Console.WriteLine("Helló!");

            Console.WriteLine("Mit választasz? (k/p/o)");

            switch(Console.ReadKey(true).KeyChar)
            {
                case 'k':
                    jatekosValaszt = "kő";
                    break;
                case 'p':
                    jatekosValaszt = "papír";
                    break;
                case 'o':
                    jatekosValaszt = "olló";
                    break;

            }

            switch(rand.Next(0,3))
            {
                case 0:
                    szamitoValaszt = "kő";
                    break;
                case 1:
                    szamitoValaszt = "papír";
                    break;
                case 2:
                    szamitoValaszt = "olló";
                    break;
            }
            if (
                (jatekosValaszt == "kő" && szamitoValaszt == "papír")
                ||
                (jatekosValaszt == "papír" && szamitoValaszt == "olló")
                ||
                (jatekosValaszt == "olló" && szamitoValaszt == "kő")
               )
            {
                Console.WriteLine("Sajnos vesztettél!");
             }
        }
    }
}
