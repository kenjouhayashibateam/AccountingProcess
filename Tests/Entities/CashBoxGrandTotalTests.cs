using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;

namespace Domain.Entities.Tests
{
    [TestClass()]
    public class CashBoxGrandTotalTests
    {
        [TestMethod()]
        public void シナリオ()
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
            OneYenBundle oneYenBundle = new OneYenBundle
            {
                Count = 10
            };
            FiveYenBundle fiveYenBundle = new FiveYenBundle
            {  
                Count = 10
            };
            TenYenBundle tenYenBundle = new TenYenBundle
            {
                Count = 10
            };
            FiftyYenBundle fiftyYenBundle = new FiftyYenBundle
            {
                Count = 10
            };
            OneHundredYenBundle oneHundredYenBundle = new OneHundredYenBundle
            {
                Count = 10
            };
            FiveHundredYenBundle fiveHundredYenBundle = new FiveHundredYenBundle
            {
                Count = 10
            };
            CashBoxGrandTotal grandTotal = new CashBoxGrandTotal(oneYen, fiveYen, tenYen, fiftyYen, oneHundredYen, fiveHundredYen,
                oneThousandYen, fiveThousandYen, tenThousandYen,oneYenBundle,fiveYenBundle,tenYenBundle,fiftyYenBundle,
                oneHundredYenBundle,fiveHundredYenBundle);
            Assert.AreEqual(grandTotal.TotalAmount, "499,660");
            Assert.AreEqual(grandTotal.TotalAmountWithUnit, "499,660円");
            Assert.AreEqual(grandTotal.TotalAmountWithUnitSpace, "499,660 円");
        }
    }
}