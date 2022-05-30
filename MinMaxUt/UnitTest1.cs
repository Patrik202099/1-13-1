using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using minMax;

namespace MinMaxUt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void minimum_HelyesErtek()
        {
            minMax_Kereses MinVagyMax = new minMax_Kereses();

            int vartEredmeny = 1;
            int kapottEredmeny = MinVagyMax.Min_Kereses();

            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void maximum_HelyesErtek()
        {
            minMax_Kereses MinVagyMax = new minMax_Kereses();

            int vartEredmeny = 100;
            int kapottEredmeny = MinVagyMax.Max_Kereses();

            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void minimum_RosszErtek()
        {
            minMax_Kereses MinVagyMax = new minMax_Kereses();

            int vartEredmeny = 1;
            int kapottEredmeny = MinVagyMax.Min_Kereses();

            Assert.AreNotEqual(vartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void maximum_RosszErtek()
        {
            minMax_Kereses MinVagyMax = new minMax_Kereses();

            int vartEredmeny = 100;
            int kapottEredmeny = MinVagyMax.Max_Kereses();

            Assert.AreNotEqual(vartEredmeny, kapottEredmeny);
        }
    }
}
