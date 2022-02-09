using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamkitalalo
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerChance, compChance, playerChoice, compChoice;
            char decision;
            playerChance = 5;
            compChance = 5;
            Random rnd = new Random();
            Console.WriteLine("Üdvözöllek!");

            Console.WriteLine("Ki találja ki a számot? (j / g)");
            decision = Convert.ToChar(Console.ReadLine());
            compChoice = rnd.Next(1, 101);

            START:
            while (playerChance > 0 && compChance > 0)
            { 
                switch (decision)
            {
                
                case 'j':
                    Console.WriteLine("A játékos tippel.");
                    Console.WriteLine(compChoice);
                    Console.WriteLine("Tippeld meg a számot: ");
                    playerChoice = Convert.ToInt32(Console.ReadLine());
                    if (compChoice == playerChoice)
                    {
                        Console.WriteLine("Gratulálok, eltaláltad!");
                        playerChance -= 1;
                        goto WINJ;
                        
                    }
                    else if (compChoice != playerChoice)
                    {
                        Console.WriteLine("Sajnos nem sikerült eltalálnod, próbáld újra.");
                        playerChance -= 1;
                        Console.WriteLine(playerChance + " lehetőséged maradt.");
                        if (playerChance == 0)
                            {
                                goto WING;
                            }
                        else
                            {
                                goto START;
                            }
                    }
                    break;

                case 'g':
                    Console.WriteLine("A gép tippel.");
                    Console.WriteLine("Válassz egy számot 1 és 100 között: ");
                    playerChoice = Convert.ToInt32(Console.ReadLine());
                    if (playerChoice == compChoice)
                    {
                        Console.WriteLine("A gép eltalálta a számot!");
                        compChance -= 1;
                        goto WING;
                    }
                    else if (playerChoice != compChoice)
                    {
                        Console.WriteLine("A gép NEM találta el a számot!");
                        compChance -= 1;
                        Console.WriteLine(compChance + " lehetősége maradt a gépnek.");
                            if (compChance == 0)
                            {
                                goto WINJ;
                            }
                            else
                            {
                                goto START;
                            }
                        }
                    break;
            }
            WING:
       
                Console.WriteLine("Sajnos vesztettél. Máskor sikerülni fog.");
                Console.WriteLine(compChance + " lehetőséggel a GÉP nyerte a játékot.");
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            
            WINJ:
            
                Console.WriteLine(playerChance + " lehetőséggel nyertél, gratulálok!");
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);

            }
            Console.ReadKey();
        }
    }
}
