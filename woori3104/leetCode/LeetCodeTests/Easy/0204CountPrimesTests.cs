using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class CountPrimesTests
    {
        [TestMethod()]
        public void CountPrimesTest()
        {
            var c = new CountPrimesClass();

            // example1
            var target = 10;
            var result = c.CountPrimes(target);
            var expected = 4;
            Assert.AreEqual(expected, result);

            // example2
            target = 0;
            result = c.CountPrimes(target);
            expected = 0;
            Assert.AreEqual(expected, result);

            //example3
            target = 1;
            result = c.CountPrimes(target);
            expected = 0;
            Assert.AreEqual(expected, result);

            //example4
            target = 2;
            result = c.CountPrimes(target);
            expected = 0;
            Assert.AreEqual(expected, result);

            //example5
            target = 3;
            result = c.CountPrimes(target);
            expected = 1;
            Assert.AreEqual(expected, result);
        }
    }
}