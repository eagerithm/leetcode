using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class LengthOfLastWordTests
    {
        [TestMethod()]
        public void LengthOfLastWordTest()
        {
            var c = new LengthOfLastWordClass();

            // example1
            var target = "hello world";
            var result = c.LengthOfLastWord(target);
            var expected = 5;
            Assert.AreEqual(expected, result);

            // example2
            target = "a ";
            result = c.LengthOfLastWord(target);
            expected = 1;
            Assert.AreEqual(expected, result);

            //example3
            target = "a be  ";
            result = c.LengthOfLastWord(target);
            expected = 2;
            Assert.AreEqual(expected, result);

            // example1
            target = "hello world";
            result = c.LengthOfLastWord2(target);
            expected = 5;
            Assert.AreEqual(expected, result);

            // example2
            target = "a ";
            result = c.LengthOfLastWord2(target);
            expected = 1;
            Assert.AreEqual(expected, result);

            //example3
            target = "a be  ";
            result = c.LengthOfLastWord2(target);
            expected = 2;
            Assert.AreEqual(expected, result);
        }
    }
}