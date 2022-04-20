using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix4
{
    class Matrix
    {
        private int sorok;
        private int oszlopok;
        private string idxErtek;
        private int[,] matrixTomb;

        public Matrix()
        {
            this.sorok = 0;
            this.oszlopok = 0;
        }

        public void meretHataroz()
        {
            Console.WriteLine("Sorok száma: ");
            this.sorok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oszlopok száma: ");
            this.oszlopok = Convert.ToInt32(Console.ReadLine());
            this.matrixTomb = new int[this.sorok, this.oszlopok];
        }

        public void ertekMegad()
        {
            for (int s = 0; s < this.matrixTomb.GetLength(0); s++)
            {
                for (int o = 0; o < this.matrixTomb.GetLength(1); o++)
                {
                    Console.Write("Számok: (sorIndex, oszlopIndex, érték): ");
                    this.idxErtek = Convert.ToString(Console.ReadLine());
                }

                // Első: melyik sorba
                // Második: melyik oszlopba
                // Harmadik: érték
            }
            Console.WriteLine(this.idxErtek);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Matrix mtx = new Matrix();
                mtx.meretHataroz();
                mtx.ertekMegad();
                Console.ReadKey();
            }
        }
    }
}