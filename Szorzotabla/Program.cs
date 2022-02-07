using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szorzotabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum;
            Random rnd = new Random();

            Console.WriteLine("Üdvözöllek!");
            Console.WriteLine("Add meg az első számot!: ");
            
            //if (args.Length == 0)
            //{
            //    firstNum = rnd.Next(0, 101);
            //    secondNum = rnd.Next(0, 101);
            //}

            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a második számot!: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("A két szám szorzata: {0}", firstNum * secondNum);

            Console.ReadKey();
        }
    }
}
