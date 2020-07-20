using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class FiftyYenCoinTests
    {
        [TestMethod()]
        public void 枚数に対する金額を返す()
        {
            FiftyYenCoin fiftyYen = new FiftyYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiftyYen.DisplayValue, "500");
            Assert.AreEqual(fiftyYen.DisplayValueWithUnit, "500円");
        }
        public void 束に対する金額を返す()
        {
            FiftyYenCoin fiftyYenBundle = new FiftyYenCoin
            {
                Count = 1
            };
            Assert.AreEqual(fiftyYenBundle,25000);
        }
    }
}