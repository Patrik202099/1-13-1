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
            int alsohatar = 1,
                felsohatar = 11,
                gondoltszam,
                tippAlsoHatar,
                tippFelsoHatar,
                tipp,
                probal = 5;

            char valaszom;

            bool eltalalta = false;

            Random rnd = new Random();

            do
            {
                Console.WriteLine("Leszel az aki gondol egy számra? (i / n): ");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    gondoltszam = rnd.Next(alsohatar, felsohatar);

                    for (int i = 0; i <= probal; i++)
                    {
                        Console.WriteLine("\nTippeljen!");
                        tipp = int.Parse(Console.ReadLine());
                        if (gondoltszam < tipp)
                        {
                            Console.WriteLine("Kisebb számra gondoltam");
                        }
                        else if (gondoltszam > tipp)
                        {
                            Console.WriteLine("Nagyobb számra gondoltam.");
                        }
                        else
                        {
                            Console.WriteLine("Gratulálok eltalálta!");
                            break;
                        }
                    }
                }
                else
                {
                    eltalalta = false;
                    tippAlsoHatar = alsohatar;
                    tippFelsoHatar = felsohatar;

                    Console.WriteLine("\n Gondolj egy számra!");
                    for (int i = 0; i <= probal; i ++j)
                    {
                        tipp = tippAlsoHatar + (tippFelsoHatar - tippAlsoHatar) / 2;
                        Console.WriteLine("Az én tippem {0} \n játékos válasza (n: nagyobbra, k: kisebbre, t: eltalálta");

                        valaszom = Console.ReadKey().KeyChar;

                        if (valaszom == 'n')
                        {
                            Console.WriteLine("nagyobb számra gondoltam");
                            tippAlsoHatar = tipp;
                        }
                        else if (valaszom == 'k')
                        {
                            Console.WriteLine("kisebbre gondoltam.");
                            tippFelsoHatar = tipp;
                        }
                        else
                        {
                            eltalalta = true;
                            Console.WriteLine("Gratullok!");
                            break;
                        }
                    }

                    if (!eltalalta)
                    {
                        Console.WriteLine("Lejárt tippek!");
                    }
                }
                    Console.WriteLine("Folytatjuk a játékot?");
                }
                while (Console.ReadKey().KeyChar == 'i');
               Console.ReadKey();
            
        }
    }
}
