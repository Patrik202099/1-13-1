using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Henger0516;

namespace HengerTeszt0516
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KeruletTeszt()
        {
            Henger hngr = new Henger();
            double eredmeny = hngr.getKerulet();
            double vartEredmeny = (31.42);

            Assert.AreEqual(eredmeny, vartEredmeny);
        }

        //public void TeruletTeszt()
        //{
        //    Henger hngr = new Henger();
        //}

        //public void FelszinTeszt()
        //{
        //    Henger hngr = new Henger();
        //}

        //public void TerfogatTeszt()
        //{
        //    Henger hngr = new Henger();
        //}

    }
}
