using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas
{
    public class Elagazas
    {
        public void LoadAndRoll()
        {
            Random rnd = new Random();
            List<int> szamosLista = new List<int>();

            // Lista feltöltése, majd a páros elemek kiíratása.

            for (int i = 0; i <= 10; i++)
            {
                szamosLista.Add(rnd.Next(1, 99));
                if (szamosLista[i] % 2 == 0)
                {
                    Console.WriteLine("A lista páros elemei: {0}", szamosLista[i]);
                }
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Elagazas elagaz = new Elagazas();
            elagaz.LoadAndRoll();
            Console.ReadKey();
        }
    }
}
