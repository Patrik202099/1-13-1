using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Csempezesv2;

namespace Csempezesv2_teszt
{
    [TestClass]
    public class Csempezes_v2_Tesztel
    {
        [TestMethod]
        public void getSzukseges_teszt()
        {
            Csempezes csempek = new Csempezes();

            double szelesseg = csempek.teruletSzelesseg;
            double magassag = csempek.magassag;
        }
    }
}
