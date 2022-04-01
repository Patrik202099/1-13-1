using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0331_Lotto
{
    class Lotto
    {
        Random rnd = new Random();
        int[] lottoSzamok = new int[5];

        public void szamGenFeltolt()
        {
            for (int i = 0; i < lottoSzamok.Length; i++)
			{
                lottoSzamok[i] = rnd.Next(1,6);   
			}

            foreach (var item in lottoSzamok)
	        {
                Console.WriteLine(item);
	        }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lotto l = new Lotto();
            l.szamGenFeltolt();
            Console.ReadKey();
        }
    }
}
