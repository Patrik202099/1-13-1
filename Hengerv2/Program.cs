using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hengerv2
{
    public class Henger
    {
        public double sugar;
        public double magassag;
        public double kerulet;
        public double terulet;
        public double felszin;
        public double terfogat;

        public Henger()
        {
            this.sugar = 0;
            this.magassag = 0;
            this.kerulet = 0;
            this.terulet = 0;
            this.felszin = 0;
            this.terfogat = 0;
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
            this.kerulet = Math.Round(2 * this.sugar * Math.PI, 2);
            return this.kerulet;
        }

        public double getTerulet()
        {
            this.terulet = Math.Round(Math.PI * (this.sugar * this.sugar), 2);
            return this.terulet;
        }

        public double getFelszin()
        {
            this.felszin = Math.Round(2 * Math.PI * this.sugar * (this.sugar + this.magassag), 2);
            return this.felszin;
        }

        public double getTerfogat()
        {
            this.terfogat = Math.Round(Math.PI * (this.sugar * this.sugar) * this.magassag, 2);
            return this.terfogat;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Henger hngr = new Henger();
            hngr.setSugar();
            hngr.setMagassag();
            Console.WriteLine("Kerülete: " + hngr.getKerulet());
            Console.WriteLine("Területe: " + hngr.getTerulet());
            Console.WriteLine("Felszíne: " + hngr.getFelszin());
            Console.WriteLine("Térfogata: " + hngr.getTerfogat());

            Console.ReadKey();
        }
    }
}
