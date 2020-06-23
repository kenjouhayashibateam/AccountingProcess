using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class TenThousandYenBillTests
    {
        [TestMethod()]
        public void TenThousandYenBillTest()
        {
            TenThousandYenBill tenThousandYen = new TenThousandYenBill
            {
                Count = 10
            };
            Assert.AreEqual(tenThousandYen.DisplayValue, "100,000");
            Assert.AreEqual(tenThousandYen.DisplayValueWithUnit, "100,000円");
        }
    }
}