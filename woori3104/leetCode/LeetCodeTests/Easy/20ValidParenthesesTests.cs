using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class ValidParenthesesTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var c = new ValidParentheses();

            // example1
            var target = "()";
            var result = c.IsValid(target);
            Assert.IsTrue(result);

            // example2
            target = "()[]{}";
            result = c.IsValid(target);
            Assert.IsTrue(result);

            //example3
            target = "(]";
            result = c.IsValid(target);
            Assert.IsFalse(result);

            //example4
            target = "([)]";
            result = c.IsValid(target);
            Assert.IsFalse(result);

            //example5
            target = "{[]}";
            result = c.IsValid(target);
            Assert.IsTrue(result);
        }
    }
}