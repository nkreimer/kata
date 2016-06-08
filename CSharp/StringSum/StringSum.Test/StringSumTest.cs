using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringSum.Test
{
    [TestClass]
    public class StringSumTest
    {
        [TestMethod]
        public void Sum_TwoNumbersReturnSum()
        {
            Assert.AreEqual("2", StringSum.Sum("1", "1"));
        }

        [TestMethod]
        public void Sum_EmptyOrNullReturnSumOfNumbers()
        {
            Assert.AreEqual("2", StringSum.Sum("", "2"));
            Assert.AreEqual("2", StringSum.Sum(null, "2"));
            Assert.AreEqual("0", StringSum.Sum("", ""));
            Assert.AreEqual("0", StringSum.Sum(null, null));
        }
    }
}
