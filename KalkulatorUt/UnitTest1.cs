using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kalkulator;

namespace KalkulatorUt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Szamologep calculator = new Szamologep();

            double vartEredmeny = 20.0;
            double kapottEredmeny = calculator.Szamolas();

            Assert.AreEqual(vartEredmeny, kapottEredmeny);

            Console.ReadKey();
        }
    }
}
