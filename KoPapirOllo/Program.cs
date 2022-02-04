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

            bool j = true;
            do
            {
                Console.WriteLine("Szeretnél még játszani? (i / n)");

                if (Console.ReadKey(true).KeyChar == 'n')
                    j = false;
            } while (j);

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
                szamitoPont ++;
                Console.WriteLine("A jelenlegi állás: \n Számítógép: {0} \n Játékos: {1}", szamitoPont, jatekosPont);
            }
            else if (jatekosValaszt == szamitoValaszt)
            {
                Console.WriteLine("A jelenlegi állás: \n Számítógép: {0} \n Játékos: {1}", szamitoPont, jatekosPont);
            }
            else
            {
                Console.WriteLine("Ezt a kört te nyerted! Gratulálok!");
                jatekosPont ++;
                Console.WriteLine("Az állás: \n Számítógép: {0} \n Játékos: {1}", szamitoPont, jatekosPont);
            }
            if (
                jatekosPont == 5
                ||
                szamitoPont == 5

               )
                {
                        if (jatekosPont == 5)
                    {
                        Console.WriteLine("A játéknak vége, a nyertes TE VAGY!");
                    }
                        else if (szamitoPont == 5)
                        {
                        Console.WriteLine("A játéknak vége, a nyertes A SZÁMÍTÓGÉP.");
                    }
                }
        Console.ReadKey();
        }
    }
}
