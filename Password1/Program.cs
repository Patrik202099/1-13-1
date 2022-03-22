using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int user, pass;

            do
            {
                Console.WriteLine("User: ");
                user = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Password: ");
                pass = Convert.ToInt32(Console.ReadLine());

                if (user != 12 && pass != 1234)     {  Console.WriteLine("Error, try again!");  }
            }   while (user != 12 && pass != 1234);
            
                Console.WriteLine("Login success!");
            

            Console.ReadKey();
        }
    }
}
