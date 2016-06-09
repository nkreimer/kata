using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OddEven.Test
{
    [TestClass]
    public class OddEvenTest
    {
        [TestMethod]
        public void OddEvenPrime_OddNumberReturnOdd()
        {
            Assert.AreEqual("Odd", OddEven.OddEvenPrime(1));
            Assert.AreEqual("Odd", OddEven.OddEvenPrime(9));
        }

        [TestMethod]
        public void OddEvenPrime_EvenNumberReturnEven()
        {
            Assert.AreEqual("Even", OddEven.OddEvenPrime(4));
            Assert.AreEqual("Even", OddEven.OddEvenPrime(98));
        }

        [TestMethod]
        public void OddEvenPrime_PrimeNumberReturnPrime()
        {
            Assert.AreEqual("Prime", OddEven.OddEvenPrime(2));
            Assert.AreEqual("Prime", OddEven.OddEvenPrime(5));
        }
    }
}
