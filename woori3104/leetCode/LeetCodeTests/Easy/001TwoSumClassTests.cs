using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class TwoSumClassTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            var c = new TwoSumClass();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var result = c.TwoSum(nums, target);
            int[] expected = { 0, 1 };
            for (var i =0; i<result.Length; i++)
                Assert.AreEqual(result[i], expected[i]);

            int[] nums2 = { 3, 2, 4 };
            int target2 = 6;
            var result2 = c.TwoSum(nums2, target2);
            int[] expected2 = { 1, 2 };
            for (var i = 0; i < result.Length; i++)
                Assert.AreEqual(result2[i], expected2[i]);
        }
    }
}