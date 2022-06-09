using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tesla;

namespace tesla_teszt
{
    [TestClass]
    public class UnitTest1
    {
        int vart, kapott;
        Tegla tegla = new Tegla();

        [TestMethod]
        public void Felszin_TesztJo1()
        {
            tegla.setTegla(1, 2, 3);
            vart = 22;

            kapott = tegla.getFelszin();
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void Felszin_TesztJo2()
        {
            tegla.setTegla(2, 1, 3);
            vart = 22;

            kapott = tegla.getFelszin();
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void Felszin_TesztJo3()
        {
            tegla.setTegla(4, 2, 3);
            vart = 48;

            kapott = tegla.getFelszin();
            Assert.AreNotEqual(vart, kapott);
        }
        [TestMethod]
        public void Felszin_TesztJo4()
        {
            tegla.setTegla(4, 3, 2);
            vart = 48;

            kapott = tegla.getFelszin();
            Assert.AreNotEqual(vart, kapott);
        }
        [TestMethod]          /// Felszin_Rossz 
        public void Felszin_TesztRossz1()
        {
            tegla.setTegla(4, 3, 2);
            vart = 6;

            kapott = tegla.getFelszin();
            Assert.AreNotEqual(vart, kapott);
        }
        [TestMethod]
        public void Felszin_TesztRossz2()
        {
            tegla.setTegla(4, 3, 2);
            vart = 6;

            kapott = tegla.getFelszin();
            Assert.AreNotEqual(vart, kapott);
        }
        [TestMethod]    /// Terfogat_Jo
        public void Terfogat_TesztJo1()
        {
            tegla.setTegla(4, 3, 2);
            vart = 24;

            kapott = tegla.getTerfogat();
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void Terfogat_TesztJo2()
        {
            tegla.setTegla(1, 2, 5);
            vart = 10;

            kapott = tegla.getTerfogat();
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void Terfogat_TesztJo3()
        {
            tegla.setTegla(6, 6, 6);
            vart = 216;

            kapott = tegla.getTerfogat();
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void Terfogat_TesztJo4()
        {
            tegla.setTegla(4, 5, 2);
            vart = 40;

            kapott = tegla.getTerfogat();
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod] ///  Terfogat_Rossz
        public void Terfogat_TesztRossz1()
        {
            tegla.setTegla(6, 6, 6);
            vart = 11;

            kapott = tegla.getTerfogat();
            Assert.AreNotEqual(vart, kapott);
        }
        [TestMethod]
        public void Terfogat_TesztRossz()
        {
            tegla.setTegla(4, 5, 2);
            vart = 60;

            kapott = tegla.getTerfogat();
            Assert.AreNotEqual(vart, kapott);
        }
    }
}
