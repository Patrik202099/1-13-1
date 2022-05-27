using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_0527
{
    public class Szamologep
    {
        public double elsoNum, masodikNum;
        public char oper;
        public Szamologep()
        {
            this.elsoNum = 0;
            this.masodikNum = 0;
            this.oper = ' ';
        }

        public void ErtekBeker()
        {
            Console.WriteLine("Első szám: ");
            this.elsoNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Operátor: ");
            this.oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Második szám: ");
            this.masodikNum = Convert.ToDouble(Console.ReadLine());

        }

        public double Szamolas()
        {
            if (this.oper == '+') { return this.elsoNum + this.masodikNum; }
            else if (this.oper == '-') { return this.elsoNum - this.masodikNum; }
            else if (this.oper == '/') { return this.elsoNum / this.masodikNum; }
            else if (this.oper == '*') { return this.elsoNum * this.masodikNum; }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Szamologep calculator = new Szamologep();
            calculator.ErtekBeker();
            calculator.Szamolas();

            Console.ReadKey();
        }
    }
}
