using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class FiveYenCoinTests
    {
        [TestMethod()]
        public void FiveYenCoinTest()
        {
            FiveYenCoin fiveYen = new FiveYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiveYen.Amount, 50);
            Assert.AreEqual(fiveYen.DisplayValueWithUnit, "50円");
        }
    }
}