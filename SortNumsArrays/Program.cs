using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumsArrays
{
    class ArrayNumSort
    {
        private int [] numArr;
        public ArrayNumSort()
        {   }
        public void Sorting()
        {
            this.numArr = new int [10];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayNumSort ans = new ArrayNumSort();
            Console.ReadKey();
        }
    }
}
