using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class TenYenCoinTests
    {
        [TestMethod()]
        public void TenYenCoinTest()
        {
            TenYenCoin tenYen = new TenYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(tenYen.DisplayValue, "100");
            Assert.AreEqual(tenYen.DisplayValueWithUnit, "100円");
        }
    }
}