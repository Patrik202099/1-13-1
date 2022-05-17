using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Hengerv2;

namespace Hengerv2Teszt
{
    [TestClass]
    public class HengerTeszt
    {
        [TestMethod]
        public void KeruletTeszt()
        {
            Henger hngr = new Henger();
            double kerulet_kapott = hngr.getKerulet();
            double kerulet_vart = 31.42;

            Assert.AreEqual(kerulet_kapott, kerulet_vart);
        }

        public void TeruletTeszt()
        {
            Henger hngr = new Henger();
            double terulet_kapott = hngr.getTerulet();
            double terulet_vart = 78.54;

            Assert.AreEqual(terulet_kapott, terulet_vart);
        }

        public void FelszinTeszt()
        {
            Henger hngr = new Henger();
            double felszin_kapott = hngr.getFelszin();
            double felszin_vart = 314.16;

            Assert.AreEqual(felszin_kapott, felszin_vart);
        }

        public void TerfogatTeszt()
        {
            Henger hngr = new Henger();
            double terfogat_kapott = hngr.getTerfogat();
            double terfogat_vart = 392.7;

            Assert.AreEqual(terfogat_kapott, terfogat_vart);
        }
    }
}
