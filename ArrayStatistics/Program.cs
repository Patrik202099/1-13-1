using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = true;
            int option = 0;
            int count = 0;
            int total = 0;
            int whatTo, searchNum;
            int[] array = new int[1000];
            do
            {
                Console.WriteLine("What to do?: ");
                whatTo = Convert.ToInt32(Console.ReadLine());
                switch (whatTo)
                {
                    case 1:
                        Console.WriteLine("Add a new number: ");
                        array[count] = Convert.ToInt32(Console.ReadLine());
                        total += array[count];
                        count++;
                        break;

                    case 2:
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(array[i]);
                        }
                        break;

                    case 3:
                        Console.WriteLine("What num are ya lookin fo?: ");
                        searchNum = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            if (array[i] == searchNum)
                            {
                                found = true;
                            }
                            if (found)
                            {
                                Console.WriteLine("The number you are searching {0} is in the array at index: {1}.", searchNum, array[i]);
                            }
                            else
                            {
                                Console.WriteLine("The number you are searching {0} is NOT in the array.", searchNum);
                                found = false;
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Total data: {0}", count);
                        Console.WriteLine("Data SUM: {0}", total);
                        Console.WriteLine("Data average: {0}", total / count);
                        break;

                    default:
                        Console.WriteLine("Wrong option! Choose from 1-5.");
                        break;
                }
                
            }
            while (option != 5);

            Console.ReadKey();
        }
    }
}
