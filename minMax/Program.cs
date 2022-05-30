using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMax
{
    public class minMax_Kereses
    {
        int[] szamTomb;
        public minMax_Kereses()
        {
            this.szamTomb = new int[] {1,3,13,25,100};
        }

       //public void TombToltes()
        //{
           // for (int i = 0; i < this.szamTomb.Length; i++)
           // {
              //  Console.WriteLine("Számot!: ");
              //  this.szamTomb[i] = Convert.ToInt32(Console.ReadLine());

           // }
       // }

        //public void TombKiirat()
        //{
           // Console.WriteLine("\n");
            //foreach (var item in this.szamTomb)
            //{
            //    Console.WriteLine("A tömb eleme: "+ item);
           // }
       // }

        public int Min_Kereses()
        {
            Array.Sort(this.szamTomb);
            return this.szamTomb[0];
        }

        public int Max_Kereses()
        {
            return this.szamTomb[4];
        }
        class Program
        {
            static void Main(string[] args)
            {
                minMax_Kereses minorMax = new minMax_Kereses();
                //minorMax.TombToltes();
                //minorMax.TombKiirat();
                Console.WriteLine("\nA tömb minimum értéke: " + minorMax.Min_Kereses());
                Console.WriteLine("A tömb maximum értéke: " + minorMax.Max_Kereses());

                Console.ReadKey();
            }
        }
    }
}
