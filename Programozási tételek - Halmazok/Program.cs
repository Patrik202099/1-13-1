using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek___Halmazok
{
    class Halmaz
    {
        int[] A;
        int[] B;
        Random rnd = new Random();
        List<int> metszetSzam = new List<int>();

        public Halmaz(int elemSzam)
        {
            this.A = new int [elemSzam];
            this.B = new int [elemSzam];
        }

        // A és B tömb létrehozása, majd számokkal való feltöltése.
        public void TombokLetrehoz()
        {
            for (int i = 0; i < this.A.Length; i++)
            {
                this.A[i] =this.rnd.Next(0, 5);
                this.B[i] =this.rnd.Next(0, 5);
            }
            foreach (var item in A)
	        {
                Console.WriteLine("A tömb elemei: {0}",item);
	        }
            Console.WriteLine("---------------");
            foreach (var item in B)
	        {
                Console.WriteLine("B tömb elemei: {0}",item);
	        } 
            
        }

        public void aMinusB()
        {   
            var onlyA = this.A.Except(this.B);
            Console.WriteLine("Csak az A-ban szereplő szám(ok): " + String.Join(", ", onlyA));
        }

        public void bMinusA()
        {
            var onlyB = this.B.Except(this.A);
            Console.WriteLine("Csak a B-ben szereplő szám(ok): " + String.Join(", ", onlyB));
        }

        public void Unio()
        {
            var unio = this.A.Union(this.B);
            Console.WriteLine("A két tömb uniója: " + String.Join(", ", unio));
        }

        public void Metszet()
        {
            
            for (int i = 0; i < this.A.Length; i++)
			{
                for (int j = 0; j < this.B.Length; j++)
			{
                    if (this.A[i] == this.B[j]) 
                    {
                        Console.WriteLine("A metszete: {0}", A[i]);
                    }
			}

			}
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Hány számot: (max 200)");
            int elemSzam = Convert.ToInt32(Console.ReadLine());
            if (elemSzam > 200) { elemSzam = rnd.Next(100, 201); }
            Console.WriteLine("Választott elemek száma: {0}",elemSzam);
            Halmaz h = new Halmaz(elemSzam);
            h.TombokLetrehoz();
            h.aMinusB();
            h.bMinusA();
            h.Unio();
            h.Metszet();
            Console.ReadKey();
        }
    }
}
