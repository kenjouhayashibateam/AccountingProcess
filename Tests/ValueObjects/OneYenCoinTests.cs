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
        public void AmountTest()
        {
            var oneyen = new OneYenCoin(1);
        }

        [TestMethod()]
        public void OneYenCoinTest()
        {

        }
    }
}