using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYear.Test
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void IsLeapYear_WithLeapYearReturnTrue()
        {
            Assert.AreEqual(true, LeapYear.IsLeapYear("1996"));
            Assert.AreEqual(true, LeapYear.IsLeapYear("2000"));
        }

        [TestMethod]
        public void IsLeapYear_WithNonLeapYearReturnFalse()
        {
            Assert.AreEqual(false, LeapYear.IsLeapYear("2001"));
            Assert.AreEqual(false, LeapYear.IsLeapYear("1900"));
        }
    }
}
