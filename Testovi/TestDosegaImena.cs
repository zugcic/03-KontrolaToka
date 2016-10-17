using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestDosegaImena : ConsoleTest
    {
        [TestMethod]
        public void DosegImena()
        {
            DosegImena p = new DosegImena();
            p.IspišiAove();
            Assert.AreEqual("Lokalna varijabla", cw.GetString());
            Assert.AreEqual("Član klase", cw.GetString());
        }
    }
}
