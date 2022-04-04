using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    public class Listak
    {
        public void Feltoltes()
        {
            Random rnd = new Random();
            List<int> szamLista = new List<int>();

            // Lista feltöltése
            for (int i = 0; i <= 10; i++)
            {
                szamLista.Add(rnd.Next(10, 100));
            }

            // Lista elemek kiíratása
            foreach (var item in szamLista)
            {
                Console.WriteLine(item);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Listak lista = new Listak();
            lista.Feltoltes();
            Console.ReadKey();
        }
    }
}
