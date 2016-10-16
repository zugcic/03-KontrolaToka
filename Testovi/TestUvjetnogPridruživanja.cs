using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestUvjetnogPridruživanja : ConsoleTest
    {
        [TestMethod]
        public void TestUvjetnogPridruživanja_IspišiParnostUvjetnimPridruživanjem()
        {
            IspišiParnost.UvjetnimPridruživanjem(1);
            Assert.AreEqual("Broj 1 je neparan", cw.Get());
            IspišiParnost.UvjetnimPridruživanjem(2);
            Assert.AreEqual("Broj 2 je paran", cw.Get());
            IspišiParnost.UvjetnimPridruživanjem(3);
            Assert.AreEqual("Broj 3 je neparan", cw.Get());
            IspišiParnost.UvjetnimPridruživanjem(4);
            Assert.AreEqual("Broj 4 je paran", cw.Get());
        }

        [TestMethod]
        public void TestUvjetnogPridruživanja_IspišiParnostGrananjemIf()
        {
            IspišiParnost.GrananjemIf(1);
            Assert.AreEqual("Broj 1 je neparan", cw.Get());
            IspišiParnost.GrananjemIf(2);
            Assert.AreEqual("Broj 2 je paran", cw.Get());
            IspišiParnost.GrananjemIf(3);
            Assert.AreEqual("Broj 3 je neparan", cw.Get());
            IspišiParnost.GrananjemIf(4);
            Assert.AreEqual("Broj 4 je paran", cw.Get());
        }
    }
}
