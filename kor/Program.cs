using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    // t = 3.14*(r*r)
    // k = 2*3.14.r

    class Kor
    {
        double beker;

        public Kor()
        {
            
        }

        public double Kerulet()
        {
            return 2 * 3.14*this.beker;
        }

        public double Terulet()
        {
            return 3.14 * (this.beker * this.beker);
        }
        public void setSugar()
        {
            this.beker = Convert.ToDouble(Console.ReadLine());
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kör sugara: ");
            Kor k = new Kor();
            k.setSugar();
            Console.WriteLine("A kör kerülete {0}", k.Kerulet());
            Console.WriteLine("A kör területe {0}", k.Terulet());
            Console.ReadKey();
        }
    }
}
