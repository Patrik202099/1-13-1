using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervallumban
{
    class Program
    {
        static void Main(string[] args)
        {
            int kezdoErtek,
                utolsoErtek;

            Console.WriteLine("Add meg az intervallum kezdő értékét: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg az intervallum utolsó értékét: ");
            utolsoErtek = Convert.ToInt32(Console.ReadLine());

            for (int i = kezdoErtek; i < utolsoErtek; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Az 5-el osztható számok: {0}",i);
                }
            }
            Console.ReadKey();
        }
    }
}
