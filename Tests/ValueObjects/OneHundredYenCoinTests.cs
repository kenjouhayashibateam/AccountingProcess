using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

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