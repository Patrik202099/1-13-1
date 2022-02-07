using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum;
            char op;

            Console.WriteLine("Üdvözöllek!");

            Console.WriteLine("Add meg az első számot!: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a második számot!: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a művelettípust (+ , - , / , *)");
            op = Convert.ToChar(Console.Read());

            switch (op)
            {
                case '+':
                    Console.WriteLine(firstNum + secondNum);
                    break;

                case '-':
                    Console.WriteLine(firstNum - secondNum);
                    break;

                case '/':
                    Console.WriteLine(firstNum / secondNum);
                    break;

                case '*':
                    Console.WriteLine(firstNum * secondNum);
                    break;

                    
            }
            Console.ReadKey();
        }
    }
}
