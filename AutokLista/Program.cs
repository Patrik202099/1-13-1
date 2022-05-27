using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutokLista
{
    public class AutoLista
    {
        public string rendszam;
        public string gyartmany;
        public string tipus;
        public DateTime gyartasiEv;
        public DateTime muszakiErveny;
        public string tulajNev;
        public List<string> beolvasas;
        public string fajlNev;
        public string beolvSor;

        public AutoLista()
        {
            this.rendszam = "";
            this.gyartmany = "";
            this.tipus = "";
            this.gyartasiEv = new DateTime();
            this.muszakiErveny = new DateTime();
            this.tulajNev = "";
            this.beolvasas = new List <string>();
            this.fajlNev = "adatok.txt";
            this.beolvSor = @"C:\Users\2021306\Source\Repos\Patrik202099\1-13-1\AutokLista\" + this.fajlNev;
        }

        public void Beolvas()
        {
            foreach (var adat in this.beolvSor)
            {
                this.beolvasas.Add(adat);
            }

            foreach (var item in this.beolvasas)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AutoLista autoList = new AutoLista();
            autoList.Beolvas();

            Console.ReadKey();
        }
    }
}
