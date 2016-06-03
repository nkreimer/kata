using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_EmptyString_ReturnZero()
        {
            Assert.AreEqual(0, Calculator.Add(""));
        }
    }
}
