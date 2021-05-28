using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Easy.Tests
{
    [TestClass()]
    public class DefanginganIPAddressTest
    {
        [TestMethod()]
        public void DefangIPaddrTest()
        {
            var c = new DefanginganIPAddress();

            // example1
            var address = "1.1.1.1";
            var result = c.DefangIPaddr(address);
            var expected = "1[.]1[.]1[.]1";
            Assert.AreEqual(result, expected);

            // example2
            address = "255.100.50.0";
            result = c.DefangIPaddr(address);

            expected = "255[.]100[.]50[.]0";
            Assert.AreEqual(result, expected);

        }
    }
}