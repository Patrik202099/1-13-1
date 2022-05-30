using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sziget
{
    public class SzigetHosszok
    {
        string szigetErtekek;

        public SzigetHosszok()
        {
            this.szigetErtekek = "0111001100";
        }

        public int szigetDrbSz()
        {

        }

        public int hosszVizsgalat()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SzigetHosszok szigetHossz = new SzigetHosszok();
            Console.WriteLine("Szigetek száma: " + szigetHossz.szigetDrbSz());
            Console.WriteLine("Leghosszabb sziget hossza: "+ szigetHossz.hosszVizsgalat());

            Console.ReadKey();
        }
    }
}
