using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestUsporedbeRealnihBrojeva
    {
        [TestMethod]
        public void TestUsporedbeDvijeTrećine()
        {
            double tri = 3.0;
            Assert.IsTrue(UsporedbeRealnihBrojeva.JednakiSu((1.0 - 1.0 / tri), (2.0 / tri)));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(0.6666667, (1.0 - 1.0 / tri)));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(0.6666667, (2.0 / tri)));
        }

        [TestMethod]
        public void TestUsporedbeTriDesetine()
        {
            double tri = 3.0;
            Assert.IsTrue(UsporedbeRealnihBrojeva.JednakiSu(tri * 0.1, 0.3));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(0.3000001, tri * 0.1));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(0.3000001, 0.3));
        }
    }
}
