using System;
using LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Easy
{
    [TestClass()]
    public class MySqrtTests
    {
        [TestMethod()]
        public void MySqrtTest()
        {
            var c = new MySqrtClass();

            // example1
            var input = 9;
            var result = c.MySqrt(input);
            var expected = 3;
            Assert.AreEqual(result, expected);

            // example2
            input = 0;
            result = c.MySqrt(input);
            expected = 0;
            Assert.AreEqual(result, expected);

            // example3
            input = 1;
            result = c.MySqrt(input);
            expected = 0;
            Assert.AreEqual(result, expected);

            // example4
            input = 2147395599;
            result = c.MySqrt(input);
            expected = 46339;
            Assert.AreEqual(result, expected);

        }
    }
}
