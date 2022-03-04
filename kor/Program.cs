using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    class Kor
    {
        private double beker;

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
    
    class Henger:Kor
    {
        private double magassag;

        public Henger():base()
        { }

        public double AlapTerulet()
        {
            return this.Terulet();
        }

        public double Terfogat()
        {
            return this.Terulet()*this.magassag;
        }

        public void setMagassag()
        {
            this.magassag = Convert.ToDouble(Console.ReadLine());
        }
    }
    // származtatás henger osztály magasság bekér metódusokkal kiiratni térfogat és alapterület
    // henger alapterület = 3.14*(r*r)
    // henger terfogat = 3.14*(r*r)*m

    class Program
    {
        static void Main(string[] args)
        {
            Henger h = new Henger();
            Console.WriteLine("Kör sugara: ");
            h.setSugar();
            Console.WriteLine("Henger magassága: ");
            h.setMagassag();
            Console.WriteLine("A kör kerülete {0}", h.Kerulet());
            Console.WriteLine("A kör területe {0}", h.Terulet());
            Console.WriteLine("A henger alapterülete: {0}", h.AlapTerulet());
            Console.WriteLine("A henger térfogata: {0}", h.Terfogat());

            Console.ReadKey();
        }
    }
}
