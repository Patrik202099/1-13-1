using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek___Halmazok
{
    class Halmaz
    {
        int elemSzam;
        Random rnd = new Random();
        public void DarabSzamLetrehoz()
        {
            Console.WriteLine("Hány számot: (max 200)");
            this.elemSzam = Convert.ToInt32(Console.ReadLine());
            if (this.elemSzam > 200) { this.elemSzam = rnd.Next(100, 201); }
            // Console.WriteLine(elemSzam);
        }
        public void TombokLetrehoz()
        {
            int[] A = { };
            int[] B = { };
            for (int i = 0; i < elemSzam; i++)
            {
                rnd.Next(-100, 100);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Halmaz h = new Halmaz();
            h.DarabSzamLetrehoz();
            Console.ReadKey();
        }
    }
}
