using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.Tests
{
    [TestClass()]
    public class OneThousandYenBillTests
    {
        [TestMethod()]
        public void OneThousandYenBillTest()
        {
            OneThousandYenBill oneThousandYen = new OneThousandYenBill
            {
                Count = 10
            };
            Assert.AreEqual(oneThousandYen.DisplayValue, "10,000");
            Assert.AreEqual(oneThousandYen.DisplayValueWithUnit, "10,000円");
        }
    }
}