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
            Random rnd = new Random();

            string playerChoice = "";
            string compChoice = "";

            int playerPoint = 0;
            int compPoint = 0;

            Console.WriteLine("Üdvözöllek!");

            bool g = true;
            do
            {
                Console.WriteLine("Szeretnél még játszani? (i / n)");

                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    g = false;
                    Console.WriteLine("Viszlát!");
                    break; 
                }
            } while (g == true);

            Console.WriteLine("Mit választasz?: ");
            switch (Console.ReadKey(true).KeyChar)

            {
                case 'k':
                    playerChoice = "kő";
                    break;

                case 'p':
                    playerChoice = "papír";
                    break;

                case 'o':
                    playerChoice = "olló";
                    break;
            }

            Console.ReadKey();
        }
    }
}


