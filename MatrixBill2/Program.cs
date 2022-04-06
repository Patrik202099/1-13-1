using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill
{
    public class Matrix
    {
        private int[,] szamTomb;
        private int sor;
        private int oszlop;
        private int sorElemek;
        private int oszlopElemek;

        public void Letrehozas()
        {
            Console.WriteLine("Oszlopok száma:");
            this.oszlop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sorok száma:");
            this.sor = Convert.ToInt32(Console.ReadLine());
            this.szamTomb = new int[this.oszlop, this.sor];

        }

        public void Feltoltes()
        {
            for (int o = 0; o < this.oszlop; o++)
            {
                for (int s = 0; s < this.sor; s++)
                {
                    Console.WriteLine("Elemek: ");
                    this.szamTomb[o, s] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Kiirat()
        {
            foreach (var item in this.szamTomb)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix mtx = new Matrix();
            mtx.Letrehozas();
            mtx.Feltoltes();
            mtx.Kiirat();
            Console.ReadKey();
        }
    }
}
    