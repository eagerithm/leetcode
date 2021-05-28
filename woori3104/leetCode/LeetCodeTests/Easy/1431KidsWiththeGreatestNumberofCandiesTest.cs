using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class KidsWiththeGreatestNumberofCandiesTest
    {
        [TestMethod()]
        public void KidsWithCandiesTest()
        {
            var c = new KidsWiththeGreatestNumberofCandies();

            // example 1
            int[] candies = { 2, 3, 5, 1, 3 };
            var extraCandies = 3;
            var result = c.KidsWithCandies(candies, extraCandies);
            bool[] expecteds = { true, true, true, false, true };

            for (var i =0; i< expecteds.Length; i++)
                Assert.AreEqual(expecteds[i], result[i]);

            // example 2
            int[] candies2 = { 4, 2, 1, 1, 2 };
            extraCandies = 1;
            result = c.KidsWithCandies(candies2, extraCandies);
            bool[] expecteds2 = { true,false,false,false,false};

            for (var i = 0; i < expecteds2.Length; i++)
                Assert.AreEqual(expecteds2[i], result[i]);

            int[] candies3 = { 12, 1, 12 };
            extraCandies = 10;
            result = c.KidsWithCandies(candies3, extraCandies);
            bool[] expecteds3 = { true, false, true };

            for (var i = 0; i < expecteds3.Length; i++)
                Assert.AreEqual(expecteds3[i], result[i]);


        }
    }
}