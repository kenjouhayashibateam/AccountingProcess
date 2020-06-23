using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class FiftyYenCoinTests
    {
        [TestMethod()]
        public void FiftyYenCoinTest()
        {
            FiftyYenCoin fiftyYen = new FiftyYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiftyYen.DisplayValue, "500");
            Assert.AreEqual(fiftyYen.DisplayValueWithUnit, "500円");
        }
    }
}