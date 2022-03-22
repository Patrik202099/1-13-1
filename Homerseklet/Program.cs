using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    public class Homerseklet(string asd)
    {
        string honap;
        int nap;
        int NapiMin, NapiMax;
        asd = "x";
        public void EvszakEldont()
        {
            Console.WriteLine("Hónap: ");
            honap = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nap: ");
            this.nap = Convert.ToInt32(Console.ReadLine());

            if (honap == "Március")
            {
                this.asd = "wasd";
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
            h.EvszakEldont();
            Console.WriteLine(this.asd);
            Console.ReadKey();
        }
    }
}
