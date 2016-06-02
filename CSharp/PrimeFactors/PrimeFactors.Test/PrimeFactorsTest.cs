using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactors.Test
{
    [TestClass]
    public class PrimeFactorsTest
    {
        private List<int> list(int[] ints = null)
        {
            List<int> list = new List<int>();
            if (ints != null)
            {
                foreach (int i in ints)
                    list.Add(i);
            }
            return list;
        }

        [TestMethod]
        public void TestOne()
        {
            CollectionAssert.AreEqual(list(), PrimeFactors.Generate(1));
        }

        [TestMethod]
        public void TestTwo()
        {
            CollectionAssert.AreEqual(list(new int[2]), PrimeFactors.Generate(2));
        }
    }
}
