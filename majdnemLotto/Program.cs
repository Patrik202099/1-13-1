using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majdnemLotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int counter = 0;
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 7);
                Console.WriteLine(array[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 6)
                {
                    
                    counter ++;
                }
            }
            Console.WriteLine(counter,  "{0}x volt hatos.");
            Console.ReadKey();
        }
        
    }
}
