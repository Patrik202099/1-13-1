using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int eselyek = 0;
            string helyek = "";
            bool dontes = true;
            char jatekosTalal;
            Random rnd = new Random();
            List<string> gondolas = new List<string> { "banán", "alma", "körte", "répa", "mogyoró", "szilva" };
            string gepGondolt;

            gepGondolt = gondolas[rnd.Next(0, 6)];

            for (int i = 0; i < gepGondolt.Length; i++)
            {
                helyek += "_ ";
            }

            Console.WriteLine("A gép által gondolt szó: {0}", helyek);
            

            while (dontes)
            {
                Console.WriteLine("Gondolj egy betűre: ");
                jatekosTalal = Convert.ToChar(Console.ReadKey());
            }    

            Console.ReadKey();
        }
    }
}
