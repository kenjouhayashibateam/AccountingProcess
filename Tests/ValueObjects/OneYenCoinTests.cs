using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class OneYenCoinTests
    {
        [TestMethod()]
        public void OneYenCoinTest()
        {
            OneYenCoin oneYen = new OneYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(oneYen.Amount, 10);
            Assert.AreEqual(oneYen.DisplayValueWithUnit, "10円");
        }
    }
}