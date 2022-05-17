using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csempezesv2
{
    public class Csempezes
    {
        public double teruletSzelesseg;
        public double magassag;
        public double szukseges;
        public double csempe;

        public Csempezes()
        {
            this.teruletSzelesseg = 0;
            this.magassag = 5;
            this.szukseges = 5;
            this.csempe = 0.2 * 0.2;
        }

        public void setSzelesseg()
        {
            Console.WriteLine("Terület szélessége: ");
            this.teruletSzelesseg = Convert.ToDouble(Console.ReadLine());
        }

        public void setMagassag()
        {
            Console.WriteLine("Magasság méterben: ");
            this.magassag = Convert.ToDouble(Console.ReadLine());
        }

        public double getSzukseges()
        {
            this.szukseges = (this.teruletSzelesseg * this.magassag) / this.csempe;
            return Math.Round(this.szukseges + this.szukseges * 0.1,2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Csempezes csempek = new Csempezes();
            csempek.setSzelesseg();
            csempek.setMagassag();
            Console.WriteLine(csempek.getSzukseges() + " darab csempe szükséges.");

            Console.ReadKey();

        }
    }
}
