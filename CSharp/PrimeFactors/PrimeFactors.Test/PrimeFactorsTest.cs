using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactors.Test
{
    [TestClass]
    public class PrimeFactorsTest
    {
        [TestMethod]
        public void ShouldFactorOne()
        {
            CollectionAssert.AreEquivalent(new int[0], PrimeFactors.Generate(1));
        }

        [TestMethod]
        public void ShouldFactorTwo()
        {
            CollectionAssert.AreEquivalent(new[] { 2 }, PrimeFactors.Generate(2));
        }

        [TestMethod]
        public void ShouldFactorThree()
        {
            CollectionAssert.AreEquivalent(new[] { 3 }, PrimeFactors.Generate(3));
        }

        [TestMethod]
        public void ShouldFactorFour()
        {
            CollectionAssert.AreEquivalent(new[] { 2, 2 }, PrimeFactors.Generate(4));
        }

        [TestMethod]
        public void ShouldFactorSix()
        {
            CollectionAssert.AreEquivalent(new[] { 2, 3 }, PrimeFactors.Generate(6));
        }

        [TestMethod]
        public void ShouldFactorEight()
        {
            CollectionAssert.AreEquivalent(new[] { 2, 2, 2 }, PrimeFactors.Generate(8));
        }

        [TestMethod]
        public void ShouldFactorNine()
        {
            CollectionAssert.AreEquivalent(new[] { 3, 3 }, PrimeFactors.Generate(9));
        }

        [TestMethod]
        public void ShouldFactorFourtyTwo()
        {
            CollectionAssert.AreEquivalent(new[] { 2, 3, 7 }, PrimeFactors.Generate(42));
        }

        [TestMethod]
        public void ShouldFactor()
        {
            CollectionAssert.AreEquivalent(new[] { 2, 3, 7, 11, 13 }, PrimeFactors.Generate(2*3*7*11*13));
        }

        [TestMethod]
        public void ShouldFactorMaxValue()
        {
            CollectionAssert.AreEquivalent(new[] { int.MaxValue }, PrimeFactors.Generate(int.MaxValue));
        }
    }
}
