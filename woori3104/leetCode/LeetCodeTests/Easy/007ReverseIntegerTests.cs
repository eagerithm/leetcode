using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class ReverseIntegerTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            var c = new ReverseInteger();

            // example1
            var target = 123;
            var result = c.Reverse(target);
            var expected = 321;
            Assert.AreEqual(expected, result);

            // example2
            target = -123;
            result = c.Reverse(target);
            expected = -321;
            Assert.AreEqual(expected, result);

            //example3
            target = 120;
            result = c.Reverse(target);
            expected = 21;
            Assert.AreEqual(expected, result);


            target = 0;
            result = c.Reverse(target);
            expected = 0;
            Assert.AreEqual(expected, result);
        }
    }
}