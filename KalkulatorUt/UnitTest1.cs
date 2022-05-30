using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kalkulator;
using System.IO;

namespace KalkulatorUt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void helyes_osszeadTeszt()
        {
            Szamologep calculator = new Szamologep();

            var osszeadas = new StringReader("10\r\n+\r\n10");
            double osszeadVartEredmeny = 20.0;
            
            Console.SetIn(osszeadas);
            calculator.ErtekBeker();

            double kapottEredmeny = calculator.Szamolas();
            Assert.AreEqual(osszeadVartEredmeny, kapottEredmeny);
            
        }

        [TestMethod]
        public void helyes_kivonasTeszt()
        {
            Szamologep calculator = new Szamologep();

            var kivonas = new StringReader("10\r\n-\r\n5");
            double kivonasVartEredmeny = 5.0;

            Console.SetIn(kivonas);
            calculator.ErtekBeker();

            double kapottEredmeny = calculator.Szamolas();
            Assert.AreEqual(kivonasVartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void helyes_osztasTeszt()
        {
            Szamologep calculator = new Szamologep();

            var osztas = new StringReader("100\r\n/\r\n10");
            double osztasVartEredmeny = 10.0;

            Console.SetIn(osztas);
            calculator.ErtekBeker();

            double kapottEredmeny = calculator.Szamolas();
            Assert.AreEqual(osztasVartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void helyes_szorzasTeszt()
        {
            Szamologep calculator = new Szamologep();

            var szorzas = new StringReader("10\r\n*\r\n10");
            double szorzasVartEredmeny = 100.0;

            Console.SetIn(szorzas);
            calculator.ErtekBeker();

            double kapottEredmeny = calculator.Szamolas();
            Assert.AreEqual(szorzasVartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void rossz_osszeadTeszt()
        {
            Szamologep calculator = new Szamologep();

            var osszeadas = new StringReader("10\r\n+\r\n10");
            double osszeadVartEredmeny = 20.0;

            Console.SetIn(osszeadas);
            calculator.ErtekBeker();

            double kapottEredmeny = calculator.Szamolas();
            Assert.AreNotEqual(osszeadVartEredmeny, kapottEredmeny);

        }

        [TestMethod]
        public void rossz_kivonasTeszt()
        {
            Szamologep calculator = new Szamologep();

            var kivonas = new StringReader("10\r\n-\r\n5");
            double kivonasVartEredmeny = 5.0;

            Console.SetIn(kivonas);
            calculator.ErtekBeker();

            double kapottEredmeny = calculator.Szamolas();
            Assert.AreNotEqual(kivonasVartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void rossz_osztasTeszt()
        {
            Szamologep calculator = new Szamologep();

            var osztas = new StringReader("100\r\n/\r\n10");
            double osztasVartEredmeny = 10.0;

            Console.SetIn(osztas);
            calculator.ErtekBeker();

            double kapottEredmeny = calculator.Szamolas();
            Assert.AreNotEqual(osztasVartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void rossz_szorzasTeszt()
        {
            Szamologep calculator = new Szamologep();

            var szorzas = new StringReader("10\r\n*\r\n10");
            double szorzasVartEredmeny = 100.0;

            Console.SetIn(szorzas);
            calculator.ErtekBeker();

            double kapottEredmeny = calculator.Szamolas();
            Assert.AreNotEqual(szorzasVartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void nullaval_Osztas()
        {
            Szamologep calculator = new Szamologep();

            var nullaOsztas = new StringReader("10\r\n/\r\n0");
            char nullaOsztasVartEredmeny = '?';

            Console.SetIn(nullaOsztas);
            calculator.ErtekBeker();

            double kapottEredmeny = Convert.ToChar(calculator.Szamolas());
            Assert.AreEqual(nullaOsztasVartEredmeny, kapottEredmeny);

        }
    }
}
