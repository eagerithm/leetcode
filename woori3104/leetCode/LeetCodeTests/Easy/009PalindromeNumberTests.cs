using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class IsPalindromeTest
    {
        [TestMethod()]
        public void ReverseTest()
        {
            var c = new PalindromeNumber();

            // example1
            var target = 121;
            var result = c.IsPalindrome(target);
            var expected = true;
            Assert.AreEqual(expected, result);

            // example2
            target = -121;
            result = c.IsPalindrome(target);
            expected = false;
            Assert.AreEqual(expected, result);

            //example3
            target = 10;
            result = c.IsPalindrome(target);
            expected = false;
            Assert.AreEqual(expected, result);

            //example4
            target = -101;
            result = c.IsPalindrome(target);
            expected = false;
            Assert.AreEqual(expected, result);
        }
    }
}