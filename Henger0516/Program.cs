using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger0516
{
    public class Henger
    {
        double sugar;
        double magassag;

        public Henger()
        {
            this.sugar = 0;
            this.magassag = 0;
        }

        public void setSugar()
        {
            Console.WriteLine("Sugár: ");
            this.sugar = float.Parse(Console.ReadLine());
        }

        public void setMagassag()
        {
            Console.WriteLine("Magasság: ");
            this.magassag = float.Parse(Console.ReadLine());
        }

        public double getKerulet()
        {
            return 2 * this.sugar * Math.PI;
        }

        public double getTerulet()
        {
            return Math.PI * (this.sugar * this.sugar);
        }

        public double getFelszin()
        {
            return 2 * Math.PI * this.sugar * (this.sugar * this.magassag);
        }

        public double getTerfogat()
        {
            return Math.PI * (this.sugar * this.sugar) * this.magassag;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Henger hngr = new Henger();
            hngr.setSugar();
            hngr.setMagassag();
            Console.WriteLine(hngr.getKerulet());
            Console.WriteLine(hngr.getTerulet());
            Console.WriteLine(hngr.getFelszin());
            Console.WriteLine(hngr.getTerfogat());

            Console.ReadKey();
        }
    }
}
