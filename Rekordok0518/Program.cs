using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rekordok0518
{
    public class baratokAdatai
    {
        public string nev;
        public string szulDatum;
        public string nem;
        public int buliHajlam;
        public string[] sorok;
        public List<string> beolvasottData;
        public string fajlnev;

        public baratokAdatai()
        {
            this.nev = "";
            this.szulDatum = "";
            this.nem = "";
            this.buliHajlam = 0;
            this.fajlnev = "";
            this.sorok = new string[500000000];
        }

        public void Beolvas()
        {
            Console.WriteLine("Add meg a fájl nevét: ");
            this.fajlnev = Convert.ToString(Console.ReadLine());
            this.sorok = File.ReadAllLines(@"C:\Users\2021306\Source\Repos\Patrik202099\1-13-1\Rekordok0518\" + this.fajlnev);
        }

        public void Kiir()
        {
            for (int i = 0; i < this.sorok.Length; i++)
            {
                Console.WriteLine(sorok[i]);
            }
            Console.WriteLine("Beolvasás befejezve.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            baratokAdatai baratRekord = new baratokAdatai();
            baratRekord.Beolvas();
            baratRekord.Kiir();

            Console.ReadKey();
        }
    }
}
