using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class LongestCommonPrefixTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            var c = new LongestCommonPrefixClass();

            // example1
            string[] target = { "dog", "racecar", "car" };
            var result = c.LongestCommonPrefix(target);
            var expected = "";
            Assert.AreEqual(expected, result);

            // example2
            string[] target2 = { "flower","flow","flight" };
            result = c.LongestCommonPrefix(target2);
            expected = "fl";
            Assert.AreEqual(expected, result);

        }
    }
}