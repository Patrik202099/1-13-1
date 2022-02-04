using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számológép
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum;
            string oper;

            Console.WriteLine("Helló!");

            Console.WriteLine("Add meg az első számot:");
            firstNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Add meg a műveletet:");
            oper = Console.ReadLine();

            Console.WriteLine("Add meg az első számot:");
            secondNum = Convert.ToInt32(Console.ReadLine());

            
            if (oper == "-") 
            {
                Console.WriteLine(firstNum - secondNum);
            }

            if (oper == "+")
            {
                Console.WriteLine(firstNum + secondNum);
            }

            if (oper == "/")
            {
                Console.WriteLine(firstNum / secondNum);
            }

            if (oper == "*")
            {
                Console.WriteLine(firstNum * secondNum);
            }

            Console.ReadKey();
        }
    }
}
