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

            int playerScore = 0;
            int compScore = 0;

            Console.WriteLine("Üdvözöllek!");

            bool g = true;
            
               Console.WriteLine("Szeretnél még játszani? (i / n)");

                if (Console.ReadKey().KeyChar != 'i')
                {
                    g = false;
                    Console.WriteLine("Viszlát!");
                    Environment.Exit(0);
                }

                
            { 
                while (g == true);

                Console.WriteLine("Mit választasz?: (k / p / o)");
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
                switch (rnd.Next(0, 3))

                {

                    case 0:
                        compChoice = "kő";
                        break;

                    case 1:
                        compChoice = "papír";
                        break;

                    case 2:
                        compChoice = "olló";
                        break;

                }
                if ( 
                    (playerChoice == "kő" && compChoice == "papír")  
                    || 
                    (playerChoice == "papír" && compChoice == "olló")
                    ||
                    (playerChoice == "olló" && compChoice == "kő")
                   ) 

                { Console.WriteLine("Veszítettél! Az állás:\nSzámítógép: {0}\nJátékos:{1}", 
                    ++compScore, playerScore); 
                }

                else if (playerChoice == compChoice) 
                { Console.WriteLine("Döntetlen! Az állás:\nSzámítógép: {0}\nJátékos:{1}", 
                    compScore, playerScore); 
                } 

                else
                { 
                    Console.WriteLine("Nyertél! Az állás:\nSzámítógép: {0}\nJátékos:{1}",  
                    compScore, ++playerScore); 

                } 
          }
           
        }
    }
}


