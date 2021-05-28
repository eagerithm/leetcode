using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class ReverseStringTests
    {
        [TestMethod()]
        public void ReverseStringTest()
        {
            var c = new ReverseStringClass();

            // example1
            char[] s = { 'H', 'a', 'n', 'n', 'a', 'h' };
            c.ReverseString(s);
            char[] expected = { 'h', 'a', 'n', 'n', 'a', 'H' };
            for (var i =0; i<s.Length; i++)
                Assert.AreEqual(expected[i], s[i]);

            // example2
            char[] s2 = { 'h', 'e', 'l', 'l', 'o' };
            c.ReverseString(s2);
            char[] expected2 = { 'o', 'l', 'l', 'e', 'h' }; ;
            for (var i = 0; i < s2.Length; i++)
                Assert.AreEqual(expected2[i], s2[i]);

        }
    }
}