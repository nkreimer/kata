using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_ReturnZeroWhenSuppliedEmptyOrNullString()
        {
            Assert.AreEqual(0, Calculator.Add(""));
            Assert.AreEqual(0, Calculator.Add(null));
        }

        [TestMethod]
        public void Add_ReturnNumberWhenSuppliedSingleNumberInString()
        {
            Assert.AreEqual(1, Calculator.Add("1"));
            Assert.AreEqual(5, Calculator.Add("5"));
        }

        [TestMethod]
        public void Add_ReturSumWhenSuppliedNumbersInStringWithNewLineAsDelimiter()
        {
            Assert.AreEqual(5,Calculator.Add("3\n2"));
            Assert.AreEqual(6, Calculator.Add("1\n2,3"));
            Assert.AreEqual(15, Calculator.Add("1\n2\n3,4,5"));
        }

        [TestMethod]
        public void Add_ReturnSumWhenSuppliedMultipleNumbersInString()
        {
            Assert.AreEqual(3, Calculator.Add("1,2"));
            Assert.AreEqual(4, Calculator.Add("2,2"));
            Assert.AreEqual(15, Calculator.Add("1,3,6,5"));
        }

        [TestMethod]
        public void Add_ReturnSumByIgnoringMoreThanThousandWhenSuppliedMultipleNumbersInString()
        {
            Assert.AreEqual(3,Calculator.Add("0, 3, 1001"));
            Assert.AreEqual(1003, Calculator.Add("0,3,1000"));
        }

        [TestMethod]
        public void Add_WhenGivenDefinedDelimiterUsesThatDelimiter()
        {
            Assert.AreEqual(3, Calculator.Add("//*\n1*2"));
            Assert.AreEqual(3, Calculator.Add("//;\n1;2"));
            Assert.AreEqual(55, Calculator.Add("//;\n1;2;3;4;5;6;7;8;9;10"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_ThrowArgumentExceptionWhenSuppliedStringDoesNotMeetRule()
        {

            Calculator.Add("1, -1");

            // Assert - Expects exception

        }

        [TestMethod]
        public void Add_OneNumberStringWithDelimiterLineReturnNumber()
        {
            Assert.AreEqual(1, Calculator.Add("//,\n1"));
        }

        [TestMethod]
        public void Add_TwoNumberStringWithAlternativeDelimiterReturnSumeOfNumbers()
        {
            Assert.AreEqual(3, Calculator.Add("//;\n1;2"));
        }
    }
}
