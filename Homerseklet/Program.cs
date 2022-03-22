using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    public class Homerseklet
    {
        string honap;
        int nap;
        int NapiMin, NapiMax;
        string asd;
        public void EvszakEldont()
        {
            honap = Convert.ToString(Console.ReadLine());
            nap = Convert.ToInt32(Console.ReadLine());

            if (honap == "Március")
            {
                asd = "wasd";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Minden napra egy minimum és maximum hőmérséklet.
            // Ezek évszaktól függően más tartományba esnek.

            // MEGFELELÉS
            // Beírt napon mennyi volt a min - max és átlaghőmérséklet.
            // Beírt hónapban mennyi volt a min - max és átlaghőmérséklet.
            // Beírt évszakban mennyi volt a min - max és átlaghőmérséklet.
            // Összes adatot tekintve mennyi volt a min - max és átlag értéke.
            Homerseklet h = new Homerseklet();
            

            Console.WriteLine("Hónap: ");
            Console.WriteLine("Nap: ");
            h.EvszakEldont();

            Console.ReadKey();
        }
    }
}
