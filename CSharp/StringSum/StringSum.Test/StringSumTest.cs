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
        public void Sum_NonNaturalNumbersReturnSumOfNumbers()
        {
            Assert.AreEqual("2", StringSum.Sum("Z", "2"));
        }
    }
}
