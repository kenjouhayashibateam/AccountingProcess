using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class MoneyCategoryTests
    {
        [TestMethod()]
        public void AmountTest()
        {
            var oneyen = new MoneyCategory(1,2);
            Assert.AreEqual(1, oneyen.Category);
            Assert.AreEqual(2, oneyen.Amount);
        }
    }
}