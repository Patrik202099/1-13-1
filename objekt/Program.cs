using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objekt
{
   class Allat
    {
         private string nev;
         private string fajta;
         private string szin;
         private int kor;

        public Allat(string nev, string fajta, string szin)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
        }

        public Allat()
        {
            this.nev = "anonim";
            this.fajta = "ismerős";
            this.szin = "feka";
            this.kor = 1;
        }
        public string getfajta()
        {
        return this.fajta;
        }
        public string 
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
