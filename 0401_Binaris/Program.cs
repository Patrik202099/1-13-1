using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0401_Binaris
{
    class Binaris
    {
        string binSzamok;
        int cnt;
        public Binaris(string binSzamok)
        {
            this.binSzamok = binSzamok;
            this.cnt = 0;
        }
        public void BinarisVizsgalat()
        {

            for (int i = 0; i < binSzamok.Length; i++)
            {
                if (binSzamok[i] == '1')
                {
                    this.cnt++;
                }
            }
            Console.WriteLine(cnt + " darab 1-es van az általad megadott számsorban.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Binaris bin = new Binaris("010111010");
            bin.BinarisVizsgalat();
            Console.ReadKey();
        }
    }
}
