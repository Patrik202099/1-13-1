using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsomagoloCeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinnyeszam,
                dinnyeatmero;

            // Szalagnak kétszer körbe + 60 cm
            Console.WriteLine("Dinnye átmérője: ");
            dinnyeatmero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dinnyék száma: ");
            dinnyeszam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(dinnyeszam + " darab dinnyéhez " + ((dinnyeatmero * 2) + 60) + " méter szalagra van szükség.");

            Console.ReadKey();
        }
    }
}
