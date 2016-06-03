using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{

    /*
     * Write a program that prints the numbers from 1 to 100. 
     * But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
     * For numbers which are multiples of both three and five print "FizzBuzz".
    */

    [TestClass]
    public class UnitTest1
    {
        private FizzBuzz.FizzBuzz fizzBuzz = null;

        [TestInitialize]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz.FizzBuzz();
        }

        [TestMethod]
        public void TestOne()
        {
            Assert.AreEqual("1", fizzBuzz.GetString(1));
        }

        [TestMethod]
        public void TestThree()
        {
            Assert.AreEqual("Fizz", fizzBuzz.GetString(3));
        }

        [TestMethod]
        public void TestNine()
        {
            Assert.AreEqual("Fizz", fizzBuzz.GetString(9));
        }

        [TestMethod]
        public void TestFive()
        {
            Assert.AreEqual("Buzz", fizzBuzz.GetString(5));
        }

        [TestMethod]
        public void TestTen()
        {
            Assert.AreEqual("Buzz", fizzBuzz.GetString(10));
        }

        [TestMethod]
        public void TestFifteen()
        {
            Assert.AreEqual("FizzBuzz", fizzBuzz.GetString(15));
        }

        [TestMethod]
        public void TestThirty()
        {
            Assert.AreEqual("FizzBuzz", fizzBuzz.GetString(30));
        }


    }
}
