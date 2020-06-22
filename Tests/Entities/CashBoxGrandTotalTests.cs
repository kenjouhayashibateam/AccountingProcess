using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;

namespace Domain.Entities.Tests
{
    [TestClass()]
    public class CashBoxGrandTotalTests
    {
        [TestMethod()]
        public void CashBoxGrandTotalTest()
        {
            OneYenCoin oneYen = new OneYenCoin
            {
                Count = 10
            };
            FiveYenCoin fiveYen = new FiveYenCoin
            {
                Count = 10
            };
            TenYenCoin tenYen = new TenYenCoin
            {
                Count = 10
            };
            FiftyYenCoin fiftyYen = new FiftyYenCoin
            {
                Count = 10
            };
            OneHundredYenCoin oneHundredYen = new OneHundredYenCoin
            {
                Count = 10
            };
            FiveHundredYenCoin fiveHundredYen = new FiveHundredYenCoin
            {
                Count = 10
            };
            OneThousandYenBill oneThousandYen = new OneThousandYenBill
            {
                Count = 10
            };
            FiveThousandYenBill fiveThousandYen = new FiveThousandYenBill
            {
                Count = 10
            };
            TenThousandYenBill tenThousandYen = new TenThousandYenBill
            {
                Count = 10
            };
            CashBoxGrandTotal grandTotal = new CashBoxGrandTotal(oneYen, fiveYen, tenYen, fiftyYen, oneHundredYen, fiveHundredYen,
                oneThousandYen, fiveThousandYen, tenThousandYen);
            Assert.AreEqual(grandTotal.TotalAmount, "166,660");
            Assert.AreEqual(grandTotal.TotalAmountWithUnit, "166,660円");
            Assert.AreEqual(grandTotal.TotalAmountWithUnitSpace, "166,660 円");
        }
    }
}