using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _0331_Menu
{
    class Menu
    {
       public void MenuPontok()
       {
            bool folytatas = true;
            int menuPont;
            while (folytatas)
            {
                Console.WriteLine("Hanyas menüpont? 1-5");
                menuPont = Convert.ToInt32(Console.ReadLine());
                switch (menuPont)
                {
                    case 1:
                        Console.WriteLine("Első menüpont.");
                        break;

                    case 2:
                        Console.WriteLine("Kettes menüpont.");
                        break;

                    case 3:
                        Console.WriteLine("Hármas menüpont.");
                        break;

                    case 4:
                        Console.WriteLine("Négyes menüpont.");
                        break;

                    case 5:
                        Console.WriteLine("Kilépés 2 másodperc múlva.");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Hibás szám! 1-5!");
                        break;
                }
            }
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            m.MenuPontok();
            Console.ReadKey();
        }
    }
}
