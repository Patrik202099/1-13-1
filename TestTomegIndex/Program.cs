using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTomegIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double testsuly, bmi;
            int magassag;
            Console.WriteLine("Üdvözöllek!");

            Console.WriteLine("Add meg a testsúlyod: ");
            testsuly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a magasságod: ");
            magassag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A BMI értéked: " + Math.Round(testsuly / (magassag * magassag) * 10000,2));
            bmi = Convert.ToDouble(Console.ReadLine());
            
            if (bmi < 16)
            {
                Console.WriteLine("Súlyosan sovány vagy.");
            }

            else if (bmi > 16 && bmi < 17)
            {
                Console.WriteLine("Mérsékelten sovány vagy.");
            }

            else if (bmi > 17 && bmi < 19)
                Console.WriteLine("Enyhén sovány vagy.");

            else if (bmi > 19 && bmi < 25)
            {
                Console.WriteLine("Normális testsúllyal rendelkezel.");
            }

            else if (bmi > 25)
            {
                Console.WriteLine("Elhízott vagy.");
            }

            Console.ReadKey();
        }
    }
}
