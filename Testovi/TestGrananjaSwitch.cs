using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestGrananjaSwitch
    {
        [TestMethod]
        public void TestGrananjaSwitch_ImeDanaUTjednuVraćaPonedjeljak()
        {
            Assert.AreEqual("ponedjeljak", IspisDana.ImeDana(DayOfWeek.Monday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_ImeDanaUTjednuVraćaUtorak()
        {
            Assert.AreEqual("utorak", IspisDana.ImeDana(DayOfWeek.Tuesday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_ImeDanaUTjednuVraćaSrijeda()
        {
            Assert.AreEqual("srijeda", IspisDana.ImeDana(DayOfWeek.Wednesday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_ImeDanaUTjednuVraćaČetvrtak()
        {
            Assert.AreEqual("četvrtak", IspisDana.ImeDana(DayOfWeek.Thursday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_ImeDanaUTjednuVraćaPetak()
        {
            Assert.AreEqual("petak", IspisDana.ImeDana(DayOfWeek.Friday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_ImeDanaUTjednuVraćaSubota()
        {
            Assert.AreEqual("subota", IspisDana.ImeDana(DayOfWeek.Saturday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_ImeDanaUTjednuVraćaNedjelja()
        {
            Assert.AreEqual("nedjelja", IspisDana.ImeDana(DayOfWeek.Sunday));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGrananjaSwitch_ImeDanaUTjednuBacaIznimkuZaNepoznatiDan()
        {
            IspisDana.ImeDana((DayOfWeek)10);
        }

        [TestMethod]
        public void TestGrananjaSwitch_RadniNeradniVraćaRadniDanZaPonedjeljak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Monday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_RadniNeradniVraćaRadniDanZaUtorak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Tuesday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_RadniNeradniVraćaRadniDanZaSrijedu()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Wednesday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_RadniNeradniVraćaRadniDanZaČetvrtak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Thursday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_RadniNeradniVraćaRadniDanZaPetak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Friday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_RadniNeradniVraćaVikendZaSubotu()
        {
            Assert.AreEqual("vikend", IspisDana.RadniNeradni(DayOfWeek.Saturday));
        }

        [TestMethod]
        public void TestGrananjaSwitch_RadniNeradniVraćaVikendZaNedjelju()
        {
            Assert.AreEqual("vikend", IspisDana.RadniNeradni(DayOfWeek.Sunday));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGrananjaSwitch_RadniNeradniBacaIznimkuZaNepoznatiDan()
        {
            IspisDana.ImeDana((DayOfWeek)10);
        }
    }
}
