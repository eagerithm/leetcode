using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class ImplementstrStrTests
    {
        [TestMethod()]
        public void ImplementstrStrTest()
        {
            var c = new ImplementstrStr();

            // example1
            var haystack = "hello";
            var needle = "ll";

            var result = c.StrStr(haystack, needle);
            Assert.AreEqual(result, 2);

            // example2
            haystack = "aaaaa"; needle = "bba";
            result = c.StrStr(haystack, needle);
            Assert.AreEqual(result, -1);

            //example3
            haystack = ""; needle = "";
            result = c.StrStr(haystack, needle);
            Assert.AreEqual(result, 0);


        }
    }
}