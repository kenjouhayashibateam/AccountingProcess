using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class FiveYenCoinTests
    {
        [TestMethod()]
        public void FiveYenCoinTest()
        {
            FiveYenCoin fiveYen = new FiveYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiveYen.Amount, 50);
            Assert.AreEqual(fiveYen.DisplayValueWithUnit, "50円");
        }
    }
}