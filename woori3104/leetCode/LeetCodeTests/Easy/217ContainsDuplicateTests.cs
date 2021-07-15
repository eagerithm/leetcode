using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class ContainsDuplicateTests
    {
        [TestMethod()]
        public void ContainsDuplicateTest()
        {
            // Example1
            var c = new ContainsDuplicateClass();
            int[] nums = { 1, 2, 3, 1 };
            var result = c.ContainsDuplicate(nums);
            Assert.IsTrue(result);

            // Example2
            int[] nums2 = { 1, 2, 3, 4 };
            result = c.ContainsDuplicate(nums2);
            Assert.IsFalse(result);

            // Example3
            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            result = c.ContainsDuplicate(nums3);
            Assert.IsTrue(result);


        }
    }
}