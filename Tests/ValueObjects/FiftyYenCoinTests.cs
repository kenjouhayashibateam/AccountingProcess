using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class FiftyYenCoinTests
    {
        [TestMethod()]
        public void FiftyYenCoinTest()
        {
            FiftyYenCoin fiftyYen = new FiftyYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiftyYen.DisplayValue, "500");
            Assert.AreEqual(fiftyYen.DisplayValueWithUnit, "500円");
        }
    }
}