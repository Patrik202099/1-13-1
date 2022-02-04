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
            string op;

            Console.WriteLine("Helló!");

            Console.WriteLine("Add meg az első számot:");
            firstNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Add meg a műveletet:");
            oper = Console.ReadLine();

            Console.WriteLine("Add meg az első számot:");
            secondNum = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch(op)

            {
                case '+':
                    result = firstNum + secondNum;
                    break

                case '-':
                    result = firstNum - secondNum;
                    break

                case '*':
                    result = firstNum * secondNum;
                    break

                case '/':
                    result = firstNum / secondNum;
                    break
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
