using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0404_Szamrendszer
{
    class Szamrendszer
    {
        public void Atvaltas()
        {
            int beker;
            string binaris;
            string oktan;
            string hexadec;

            Console.WriteLine("Adjon meg egy számot: ");
            beker = Convert.ToInt32(Console.ReadLine());
            binaris = Convert.ToString(beker, 2);
            oktan = Convert.ToString(beker, 8);
            hexadec = Convert.ToString(beker, 16);
            Console.WriteLine("Az általad megadott szám bináris rendszerben: {0}",binaris);
            Console.WriteLine("Az általad megadott szám oktán rendszerben: {0}",oktan);
            Console.WriteLine("Az általad megadott szám hexadecimális rendszerben: {0}",hexadec);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 10esből 2-esbe 8-asba 16-osba
            Szamrendszer sz = new Szamrendszer();
            sz.Atvaltas();
            Console.ReadKey();
        }
    }
}
