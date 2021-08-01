using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Easy
{
    [TestClass()]
    public class PlusOneTests
    {
        [TestMethod()]
        public void PlusOneTest()
        {
            var c = new PlusOneClass();

            // example1
            int[] input = { 9 };
            var result = c.PlusOne(input);
            int[] expected = { 1, 0 };
            for (int i = 0; i < result.Length; i++) {
                Assert.AreEqual(expected[i], result[i]);
            }

            // example2
            int[] input1 = { 9, 9 };
            var result2 = c.PlusOne(input1);
            int[] expected2 = { 1, 0, 0 };
            for (int i = 0; i < result2.Length; i++)
            {
                Assert.AreEqual(expected2[i], result2[i]);
            }

            // example3
            int[] input3 = { 1, 2 };
            var result3 = c.PlusOne(input3);
            int[] expected3 = { 1, 3};
            for(int i = 0; i < result3.Length; i++) {
                Assert.AreEqual(expected3[i], result3[i]);
            }
        }
    }
}
