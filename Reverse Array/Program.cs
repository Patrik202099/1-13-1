using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];

            // Add
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Numbers: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Printing
            for (int i= 4; i >= 0; i--)
            {
                Console.WriteLine("Number in reverse order: {0}", nums[i]);
            }
            Console.ReadKey();
        }
    }
}
