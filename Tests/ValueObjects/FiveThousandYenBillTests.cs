using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class FiveThousandYenBillTests
    {
        [TestMethod()]
        public void FiveThousandYenBillTest()
        {
            FiveThousandYenBill fiveThousandYen = new FiveThousandYenBill
            {
                Count = 10
            };
            Assert.AreEqual(fiveThousandYen.DisplayValue, "50,000");
            Assert.AreEqual(fiveThousandYen.DisplayValueWithUnit, "50,000円");
        }
    }
}