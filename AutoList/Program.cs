using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoList
{
    public class AutoNyilvantartas
    {
        public string rendszam;
        public string gyartmany;
        public string tipus;
        public int gyartasEv;
        public string muszakiErvny;
        public string fajlNev;
        public List<string> beolvAdat;
        public string eleresiUt;
        public string[] dataLista;
        
        public AutoNyilvantartas()
        {
            this.rendszam = "";
            this.gyartmany = "";
            this.tipus = "";
            this.gyartasEv = 0;
            this.muszakiErvny = "0";
            this.fajlNev = "";
            this.eleresiUt = "";
        }

        public void Beolvas()
        {
            Console.WriteLine("Add meg a fájl nevét: ");
            this.fajlNev = Convert.ToString(Console.ReadLine());
            this.eleresiUt = @"C:\Users\vexpl\Source\Repos\Patrik202099\1-13-1\AutoList\";
            this.dataLista = File.ReadAllLines(this.eleresiUt + this.fajlNev);
            Console.WriteLine("Vége a beolvasásnak.\n");
        }

        public void Kiir()
        {
            foreach (var item in this.dataLista)
            {
                Console.WriteLine(item[0-6]);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            AutoNyilvantartas carData = new AutoNyilvantartas();
            carData.Beolvas();
            carData.Kiir();

            Console.ReadKey();
        }
    }
}
