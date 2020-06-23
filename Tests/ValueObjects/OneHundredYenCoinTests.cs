using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class OneHundredYenCoinTests
    {
        [TestMethod()]
        public void OneHundredYenCoinTest()
        {
            OneHundredYenCoin oneHundredYen = new OneHundredYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(oneHundredYen.DisplayValue, "1,000");
            Assert.AreEqual(oneHundredYen.DisplayValueWithUnit, "1,000円");
        }
    }
}