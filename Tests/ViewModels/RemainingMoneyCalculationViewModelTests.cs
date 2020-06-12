using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.ValueObjects;

namespace WPF.ViewModels.Tests
{
    [TestClass()]
    public class RemainingMoneyCalculationViewModelTests
    {
        [TestMethod()]
        public void シナリオ()
        {
            OneYenCoin oneYen = new OneYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(oneYen.Amount, 10);
            Assert.AreEqual(oneYen.DisplayValueWithYen, "10円");

            FiveYenCoin fiveYen = new FiveYenCoin
            {
                Count = 10
            };
            Assert.AreEqual(fiveYen.Amount, 50);
            Assert.AreEqual(fiveYen.DisplayValueWithYen, "50円");

            TenYenCoin tenYen = new TenYenCoin
            {
                Count=10
            }

        }
    }
}