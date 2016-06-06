﻿using System;
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

        [TestMethod]
        public void Add_OneNumberString_ReturnNumber()
        {
            Assert.AreEqual(1, Calculator.Add("1"));
            Assert.AreEqual(5, Calculator.Add("5"));
        }

        [TestMethod]
        public void Add_TwoNumberString_ReturnSumOfNumbers()
        {
            Assert.AreEqual(3, Calculator.Add("1,2"));
            Assert.AreEqual(4, Calculator.Add("2,2"));
        }

        [TestMethod]
        public void Add_MultipleNumberString_ReturnSumOfNumbers()
        {
            Assert.AreEqual(6, Calculator.Add("1,2,3"));
            Assert.AreEqual(7, Calculator.Add("2,2,3"));
        }

        [TestMethod]
        public void Add_NoNumberStringWithDelimiterLine_ReturnZero()
        {
            Assert.AreEqual(0, Calculator.Add("//,\n"));

        }

        [TestMethod]
        public void Add_OneNumberStringWithDelimiterLine_ReturnNumber()
        {
            Assert.AreEqual(1, Calculator.Add("//,\n1"));
        }

        [TestMethod]
        public void Add_TwoNumberStringWithAlternativeDelimiter_ReturnSumeOfNumbers()
        {
            Assert.AreEqual(3, Calculator.Add("//;\n1;2"));
        }
    }
}
