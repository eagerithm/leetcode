using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class RichestCustomerWealthTests
    {
        [TestMethod()]
        public void MaximumWealthTests()
        {
            var c = new RichestCustomerWealth();

            // example1
            int[][] accounts = new int[2][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 1 }
            };
            int result = c.MaximumWealth(accounts);
            int expected = 6;
            Assert.AreEqual(result, expected);


            // example2
            int[][] accounts2 = new int[3][]
             {
                new int[] { 1,5 },
                new int[] { 7,3 },
                new int[] { 3,5 }
             };
            result = c.MaximumWealth(accounts2);
            expected = 10;
            Assert.AreEqual(result, expected);

            // example3
            int[][] accounts3 = new int[3][]
             {
                new int[] { 2, 8, 7},
                new int[] { 7, 1, 3 },
                new int[] { 1, 9, 5 }
             };
            result = c.MaximumWealth(accounts3);
            expected = 17;
            Assert.AreEqual(result, expected);

        }
    }
}