using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class RunningSumOf1dArrayTests
    {
        [TestMethod()]
        public void RunningSumTest()
        {
            var c = new RunningSumOf1dArray();

            // example1
            int[] nums = { 1, 2, 3, 4 };
            int[] results1 = c.RunningSum(nums);
            int[] expected = { 1, 3, 6, 10 };
            for (var i =0; i< results1.Length; i++)
                Assert.AreEqual(expected[i], results1[i]);

            // example2
            int[] nums2 = { 1, 1, 1, 1, 1 };
            int[] results2 = c.RunningSum(nums2);
            int[] expected2 = { 1, 2, 3, 4, 5 }; ;
            for (var i = 0; i < results2.Length; i++)
                Assert.AreEqual(expected2[i], results2[i]);

            // example3
            int[] nums3 = { 3, 1, 2, 10, 1 };
            int[] results3 = c.RunningSum(nums3);
            int[] expected3 = { 3, 4, 6, 16, 17 }; ;
            for (var i = 0; i < results3.Length; i++)
                Assert.AreEqual(expected3[i], results3[i]);

        }
    }
}