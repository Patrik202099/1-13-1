using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bulizasi_Hajlam_v2
{
    public class BaratRekordok
    {
        public string nev;
        public DateTime szuletesiDatum;
        public char nem;
        public int bulizasiHajlam;

        public BaratRekordok()
        {
            this.nev = "";
            this.szuletesiDatum = new DateTime();
            this.nem = "";
            this.bulizasiHajlam = 0;
        }

        public void Beolvasas()
        {

        }
        // Rekordok beolvasása, listába helyezésük
        // 'Táblázatba' rendezés, majd kiíratás.
        // Metódusok: Beolvasas |  Kiiratas
    }
    public class Program
    {
        static void Main(string[] args)
        {
            BaratRekordok bRekords = new BaratRekordok();
            bRekords.Beolvasas();
            Console.ReadKey();
        }
    }
}
