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
        public void Sum_EmptyOrNullReplaceEmptyOrNullWithZeroReturnSumOfNumbers()
        {
            Assert.AreEqual("2", StringSum.Sum("", "2"));
            Assert.AreEqual("2", StringSum.Sum(null, "2"));
            Assert.AreEqual("0", StringSum.Sum("", ""));
            Assert.AreEqual("0", StringSum.Sum(null, null));
        }

        [TestMethod]
        public void Sum_NonNaturalNumberReplaceWithZeroReturnSumOfNumbers()
        {
            Assert.AreEqual("2", StringSum.Sum("Z", "2"));
            Assert.AreEqual("3", StringSum.Sum("3", "-1"));
            Assert.AreEqual("0", StringSum.Sum("1.1", "0"));
        }


    }
}
