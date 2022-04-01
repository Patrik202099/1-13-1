using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0331_Lotto
{
    class Lotto
    {
        Random rnd;
        int[] lottoSzamok;
        int vizsgal;

        public Lotto()
        {
            this.rnd = new Random();
            this.lottoSzamok = new int[5];
            this.vizsgal = rnd.Next(1,91);
        }

        public void szamGenFeltolt()
        {
            for (int i = 0; i < lottoSzamok.Length; i++)
			{
                lottoSzamok[i] = rnd.Next(1,91);
			}

            foreach (var item in lottoSzamok)
	        {
                Console.WriteLine("Az ötös lottó nyerőszámai: {0}",item);
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
