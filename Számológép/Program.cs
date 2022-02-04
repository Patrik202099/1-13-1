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
            int x, y;
            char op;

                Console.WriteLine("Az első szám: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("A művelet(+, -, *, /): ");
                op = Convert.ToChar(Console.Read());

                Console.WriteLine("A második szám: ");
                y = int.Parse(Console.ReadLine());

                int result = 0;

                switch (op)
                {

                    case '+':
                        result = x + y;
                        break;

                    case '-':
                        result = x - y;
                        break;

                    case '*':
                        result = x * y;
                        break;

                    case '/':
                        result = x / y;
                        break;

                }

                Console.WriteLine("A művelet eredménye: ", result);
        }
    }
}