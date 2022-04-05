using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0405_Bastya
{
    public class Bastya
    {
        int[] tabla;
        
        public Bastya()
        {
            this.tabla = new int [64];
        }
        public void BastyaElhelyez()
        {
            foreach (var item in this.tabla)
	        {
                Console.WriteLine(item);
	        }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bastya bastie = new Bastya();
            bastie.BastyaElhelyez();
            Console.ReadKey();
        }
    }
}
