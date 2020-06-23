using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WPF.Behaviors.Tests
{
    [TestClass()]
    public class IntAdjustmentTests
    {
        [TestMethod()]
        public void 渡された文字列が数字でなければ0を返す()
        {
            Assert.AreEqual(IntAdjustment.NumberConvert("1"), 1);
            Assert.AreEqual(IntAdjustment.NumberConvert("10"), 10);
            Assert.AreEqual(IntAdjustment.NumberConvert("aa"), 0);
        }
    }
}