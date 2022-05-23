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
        public string nem;
        public int bulizasiHajlam;
        public string eleresiUt;
        public string fajlNev;
        public string[] rekordElhelyez;
        public List<string> rekordLista;

        public BaratRekordok()
        {
            this.nev = "";
            this.szuletesiDatum = new DateTime();
            this.nem = "";
            this.bulizasiHajlam = 0;
            this.eleresiUt = @"C:\Users\vexpl\Source\Repos\Patrik202099\1-13-1\Bulizasi_Hajlam_v4\";
            this.fajlNev = "";
            this.rekordElhelyez = new string[999999];
            this.rekordLista = new List<string>();
        }

        public void Beolvasas()
        {
            Console.WriteLine("Add meg a fájl nevét: ");
            this.fajlNev = Convert.ToString(Console.ReadLine());

            //Sorok beolvasása
            this.rekordLista = File.ReadAllLines(this.eleresiUt + this.fajlNev).ToList();
        }

        public void Kiiratas()
        {

            foreach (var item in this.rekordLista)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            BaratRekordok bRekords = new BaratRekordok();
            bRekords.Beolvasas();
            bRekords.Kiiratas();

            Console.ReadKey();
        }
    }
}
