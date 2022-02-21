using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlagHomerseklet
{
    class Program
    {
        static void Main(string[] args)
        {

            // min -10 max 30   
            int[,] napok = new int[12, 30];
            int napMin,
                napMax;


            Random rnd = new Random();
            for (int i = 0; i < napok.GetLength(0); i++)
            {
                Console.WriteLine(i+1 + ".hónap");
                for (int j = 0; j < napok.GetLength(1); j++)
                {
                    napok[i, j] = rnd.Next(-10, 30);
                    Console.Write(napok[i, j]+ " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
