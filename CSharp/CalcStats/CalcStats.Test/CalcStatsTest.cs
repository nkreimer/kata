using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalcStats.Test
{
	[TestClass]
	public class CalcStatsTest
	{
        [TestMethod]
        public void NumberStats_WithListOfNumbersReturnMinValue()
        {
            var numbers = new List<int>() { 6, 9, 15, -2, 92, 11 };
            
            Assert.AreEqual("-2", CalcStats.NumberStats(numbers, CalcStats.CalcStatKeys.Minimum));
        }

        [TestMethod]
        public void NumberStats_WithListOfNumbersReturnMaxValue()
        {
            var numbers = new List<int>() { 6, 9, 15, -2, 92, 11 };

            Assert.AreEqual("92", CalcStats.NumberStats(numbers, CalcStats.CalcStatKeys.Maximum));
        }

        [TestMethod]
        public void NumberStats_WithListOfNumbersReturnNumberOfItems()
        {
            var numbers = new List<int>() { 6, 9, 15, -2, 92, 11 };

            Assert.AreEqual("6", CalcStats.NumberStats(numbers, CalcStats.CalcStatKeys.ElementCount));
        }

        [TestMethod]
        public void NumberStats_WithListOfNumbersReturnAverageValue()
        {
            var numbers = new List<int>() { 6, 9, 15, -2, 92, 11 };

            Assert.AreEqual("21", CalcStats.NumberStats(numbers, CalcStats.CalcStatKeys.Average));
        }
    }
}
