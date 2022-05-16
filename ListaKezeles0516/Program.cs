using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaKezeles0516
{
    public class VarosTarol
    {
        int nevDarabSzam;
        string bekertNevek;
        List<string> adatLista;
        string nevHason;
        bool eldontes;
        string nevHason1;

        public VarosTarol()
        {
            this.nevDarabSzam = 0;
            this.adatLista = new List<string>();
            this.bekertNevek = "";
            this.nevHason = "";
            this.eldontes = true;
            this.nevHason = "";
        }

        public void setDb()
        {
            Console.WriteLine("Hány nevet szeretnél tárolni?: ");
            this.nevDarabSzam = Convert.ToInt32(Console.ReadLine());
        }

        public void setNevek()
        {
            for (int i = 0; i < this.nevDarabSzam; i++)
            {
                Console.WriteLine("Add meg a neveket: ");
                this.adatLista.Add(this.bekertNevek = Convert.ToString(Console.ReadLine()));
            }
        }

        public void getNevek()
        {
            foreach (var item in this.adatLista)
            {
                Console.Write(item + ",");
            }
        }

        public void getVan()
        {
            Console.WriteLine("\nAdd meg a nevet: ");
            this.nevHason = Console.ReadLine();

                foreach (var item in this.adatLista)
                {

                    if (this.nevHason == item)
                    {
                        Console.WriteLine("Az általad megadott név szerepel a listában.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Az általad megadott név NEM szerepel a listában.");
                    }
                }

        }

        public void delNev()
        {
            Console.WriteLine("Törölni kívánt név: ");
            this.nevHason1 = Console.ReadLine();

            foreach (var item in this.adatLista)
            {
                if (this.nevHason == item)
                {
                    this.adatLista.Remove(this.nevHason);
                    Console.WriteLine("Törölve.");
                    break;
                }

                else
                {
                    this.adatLista.Add(this.nevHason);
                    Console.WriteLine("Nem szerepel, így hozzáadva.");
                }
            }
        }

        public void delLast()
        {
            this.adatLista.RemoveAt(this.adatLista.Count - 1);
            Console.WriteLine("Utolsó elem törölve.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            VarosTarol adatTar = new VarosTarol();
            adatTar.setDb();
            adatTar.setNevek();
            adatTar.getNevek();
            adatTar.getVan();
            adatTar.delNev();
            adatTar.delLast();

            Console.ReadKey();
        }
    }
}
