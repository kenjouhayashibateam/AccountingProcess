using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.ValueObjects;
using Domain.Entities;

namespace WPF.ViewModels.Tests
{
    [TestClass()]
    public class RemainingMoneyCalculationViewModelTests
    {
        [TestMethod()]
        public void シナリオ()
        {
            //金種テスト
            OneYenCoin oneYen = new OneYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(oneYen.Amount, 10);
            Assert.AreEqual(oneYen.DisplayValueWithUnit, "10円");

            FiveYenCoin fiveYen = new FiveYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiveYen.Amount, 50);
            Assert.AreEqual(fiveYen.DisplayValueWithUnit, "50円");

            TenYenCoin tenYen = new TenYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(tenYen.DisplayValue, "100");
            Assert.AreEqual(tenYen.DisplayValueWithUnit, "100円");

            FiftyYenCoin fiftyYen = new FiftyYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiftyYen.DisplayValue, "500");
            Assert.AreEqual(fiftyYen.DisplayValueWithUnit, "500円");

            OneHundredYenCoin oneHundredYen = new OneHundredYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(oneHundredYen.DisplayValue, "1,000");
            Assert.AreEqual(oneHundredYen.DisplayValueWithUnit, "1,000円");

            FiveHundredYenCoin fiveHundredYen = new FiveHundredYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiveHundredYen.DisplayValue, "5,000");
            Assert.AreEqual(fiveHundredYen.DisplayValueWithUnit, "5,000円");

            OneThousandYenBill oneThousandYen = new OneThousandYenBill
            {
                Count = 10
            };
            Assert.AreEqual(oneThousandYen.DisplayValue, "10,000");
            Assert.AreEqual(oneThousandYen.DisplayValueWithUnit, "10,000円");

            FiveThousandYenBill fiveThousandYen = new FiveThousandYenBill
            {
                Count = 10
            };
            Assert.AreEqual(fiveThousandYen.DisplayValue, "50,000");
            Assert.AreEqual(fiveThousandYen.DisplayValueWithUnit, "50,000円");

            TenThousandYenBill tenThousandYen = new TenThousandYenBill
            {
                Count = 10
            };
            Assert.AreEqual(tenThousandYen.DisplayValue, "100,000");
            Assert.AreEqual(tenThousandYen.DisplayValueWithUnit, "100,000円");
            
            CashBoxGrandTotal grandTotal = new CashBoxGrandTotal(oneYen, fiveYen, tenYen, fiftyYen, oneHundredYen, fiveHundredYen, 
                oneThousandYen, fiveThousandYen, tenThousandYen);
            Assert.AreEqual(grandTotal.TotalAmount, "166,660");
            Assert.AreEqual(grandTotal.TotalAmountWithUnit, "166,660円");
            Assert.AreEqual(grandTotal.TotalAmountWithUnitSpace, "166,660 円");
        }
    }
}