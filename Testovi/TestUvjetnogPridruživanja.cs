using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestUvjetnogPridruživanja : ConsoleTest
    {
        [TestMethod]
        public void TestIspišiParnostUvjetnimPridruživanjem()
        {
            UvjetnoPridruživanje.IspišiParnostUvjetnimPridruživanjem(1);
            Assert.AreEqual("Broj 1 je neparan", cw.Get());
            UvjetnoPridruživanje.IspišiParnostUvjetnimPridruživanjem(2);
            Assert.AreEqual("Broj 2 je paran", cw.Get());
            UvjetnoPridruživanje.IspišiParnostUvjetnimPridruživanjem(3);
            Assert.AreEqual("Broj 3 je neparan", cw.Get());
        }

        [TestMethod]
        public void TestIspišiParnostGrananjemIfPridruživanjem()
        {
            UvjetnoPridruživanje.IspišiParnostUvjetnimPridruživanjem(1);
            Assert.AreEqual("Broj 1 je neparan", cw.Get());
            UvjetnoPridruživanje.IspišiParnostUvjetnimPridruživanjem(2);
            Assert.AreEqual("Broj 2 je paran", cw.Get());
            UvjetnoPridruživanje.IspišiParnostUvjetnimPridruživanjem(3);
            Assert.AreEqual("Broj 3 je neparan", cw.Get());
        }
    }
}
