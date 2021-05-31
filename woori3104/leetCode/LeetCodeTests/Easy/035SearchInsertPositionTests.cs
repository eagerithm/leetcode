using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class SearchInsertPositionTests
    {
        [TestMethod()]
        public void SearchInsertTests()
        {
            var c = new SearchInsertPosition();

            // example1
            int[] nums = { 1, 3, 5, 6 };
            var target = 5;
            var result = c.SearchInsert(nums, target);
            var expected = 2;
            Assert.AreEqual(result, expected);

            // example2
            int[] nums2 = { 1, 3, 5, 6 };
            target = 2;
            result = c.SearchInsert(nums2, target);
            expected = 1;
            Assert.AreEqual(result, expected);

            //example3
            int[] nums3 = { 1, 3, 5, 6 };
            target = 7;
            result = c.SearchInsert(nums3, target);
            expected = 4;
            Assert.AreEqual(result, expected);

            //example4
            int[] nums4 = { 1, 3, 5, 6 };
            target = 0;
            result = c.SearchInsert(nums4, target);
            expected = 0;
            Assert.AreEqual(result, expected);

            //example5
            int[] nums5 = { 1 };
            target = 0;
            result = c.SearchInsert(nums5, target);
            expected = 0;
            Assert.AreEqual(result, expected);
        }
    }
}