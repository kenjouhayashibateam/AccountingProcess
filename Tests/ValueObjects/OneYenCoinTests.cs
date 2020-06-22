using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class OneYenCoinTests
    {
        [TestMethod()]
        public void OneYenCoinTest()
        {
            OneYenCoin oneYen = new OneYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(oneYen.Amount, 10);
            Assert.AreEqual(oneYen.DisplayValueWithUnit, "10円");
        }
    }
}