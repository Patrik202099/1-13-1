using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForeach
{
    public class ForAndForeach
    {
        Random rnd = new Random();
        int[] szamTomb = new int[5];
        public void Feltoltes()
        {
            this.szamTomb = new int[5];

            // Tömb feltöltése véletlen elemekkel, for ciklus segítségével.
            for (int i = 0; i < this.szamTomb.Length; i++)
            {
                this.szamTomb[i] = this.rnd.Next(1, 51);
            }
        }
        public void Kiiratas()
        {
            // Tömb elemeinek kiíratása for ciklus segítségével.
            for (int i = 0; i < this.szamTomb.Length; i++)
            {
                Console.WriteLine("For ciklus segítéségvel kiíratva: {0} ", szamTomb[i]); 
            }
            Console.WriteLine(" ");
            // Tömb elemeinek kiíratása foreach segítségével.
            foreach (int item in this.szamTomb)
            {
                Console.WriteLine("Foreach segítségével kiíratva: {0}", item);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ForAndForeach foraf = new ForAndForeach();
            foraf.Feltoltes();
            foraf.Kiiratas();
            Console.ReadKey();
        }
    }
}
