using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class IsomorphicStringsTests
    {
        [TestMethod()]
        public void IsIsomorphicTest()
        {
            var c = new IsomorphicStrings();

            // example1
            var s = "egg";
            var t = "add";
            var result = c.IsIsomorphic(s, t);
            Assert.IsTrue(result);

            // example2
            s = "foo";
            t = "bar";
            result = c.IsIsomorphic(s, t);
            Assert.IsFalse(result);

            // example3
            s = "paper";
            t = "title";
            result = c.IsIsomorphic(s, t);
            Assert.IsTrue(result);

        }
    }
}