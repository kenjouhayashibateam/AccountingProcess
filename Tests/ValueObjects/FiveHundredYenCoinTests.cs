using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class FiveHundredYenCoinTests
    {
        [TestMethod()]
        public void FiveHundredYenCoinTest()
        {
            FiveHundredYenCoin fiveHundredYen = new FiveHundredYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiveHundredYen.DisplayValue, "5,000");
            Assert.AreEqual(fiveHundredYen.DisplayValueWithUnit, "5,000円");
        }
    }
}