using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace teszt_tesztelese
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string vartEredmeny = "Helló Világ!";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                teszt.Program.Main();
                var kapottEredmeny = sw.ToString().Trim();
                Assert.AreEqual(kapottEredmeny, vartEredmeny);
            }

        }
    }
}
