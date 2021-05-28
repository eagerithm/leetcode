using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class RomanToIntegerTests
    {
        [TestMethod()]
        public void RomanToIntTest()
        {
            var c = new RomanToInteger();

            // example1
            var target = "III";
            var result = c.RomanToInt(target);
            var expected = 3;
            Assert.AreEqual(expected, result);

            // example2
            target = "IV";
            result = c.RomanToInt(target);
            expected = 4;
            Assert.AreEqual(expected, result);

            //example3
            target = "IX";
            result = c.RomanToInt(target);
            expected = 9;
            Assert.AreEqual(expected, result);

            //example4
            target = "LVIII";
            result = c.RomanToInt(target);
            expected = 58;
            Assert.AreEqual(expected, result);

            //example5
            target = "MCMXCIV";
            result = c.RomanToInt(target);
            expected = 1994;
            Assert.AreEqual(expected, result);
        }
    }
}