using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0404_Kettes
{
    class Kettes
    {
        public void Atvaltas()
        {
            int bekert;
            string binaris;

            Console.WriteLine("Átváltani kívánt szám: ");
            bekert = Convert.ToInt32(Console.ReadLine());

            binaris = Convert.ToString(bekert, 8);
            Console.WriteLine(binaris);
          
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kettes k = new Kettes();
            k.Atvaltas();
            Console.ReadKey();
        }
    }
}
