using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesla
{
    public class Tegla
    {
        private int szel,
            hossz,
            mag;

        public void setTegla(int szel, int hossz, int mag)
        {
            this.szel = szel;
            this.hossz = hossz;
            this.mag = mag;
        }
            
        public Tegla() 
        { 

        }

        public int getTerfogat()
        {
            return this.szel * this.hossz * this.mag;
        }
        public int getFelszin()
        {
            return 2* (this.szel*this.hossz + this.hossz*this.mag + this.szel*this.mag);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            throw new NotImplementedException();
            Tegla tgl = new Tegla();
            Console.ReadKey();
        }
    }
}
