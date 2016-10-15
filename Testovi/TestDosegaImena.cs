using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestDosegaImena : ConsoleTest
    {
        [TestMethod]
        public void TestIspisaAova()
        {
            DosegImena p = new DosegImena();
            p.IspišiAove();
            Assert.AreEqual("Lokalna varijabla", cw.Get());
            Assert.AreEqual("Član klase", cw.Get());
        }
    }
}
