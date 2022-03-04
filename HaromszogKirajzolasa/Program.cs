using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogKirajzolasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Con sole . Write("Add␣meg␣ az ␣a : ");
            4 int a = int.Pa rse(Con sole.ReadLine());
            5 str ing s = "";
            6
7 for (int i = 1; i <= a; i++)
                8 {
                9 Con sole . S e t C u r s o rP o si ti o n(2∗a−1 , i ) ;
                10 s = s + "∗";
                11 Con sole . Write(s);
                12
                13 }
            14 Con sole . ReadLine();
            Console.ReadKey();
        }
    }
}
