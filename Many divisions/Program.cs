using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_divisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum;

            do
            {
                Console.WriteLine("First number: ");
                firstNum = Convert.ToInt32(Console.ReadLine());

                if (firstNum != 0)
                {
                    Console.WriteLine("Second number:");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    if (secondNum == 0)
                    {
                        Console.WriteLine("Cannot divide by 0."); 
                    }

                else 
                {
                    Console.WriteLine("Divide is {0}", firstNum / secondNum);
                    Console.WriteLine("Remainder is {0}", firstNum % secondNum);
                }
              }
                
            }
            while (firstNum != 0);
            Console.ReadKey();
        }
    }
}
