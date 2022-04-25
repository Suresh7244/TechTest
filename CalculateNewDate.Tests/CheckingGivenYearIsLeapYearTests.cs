using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateNewDate.Tests
{
    [TestClass]
    public class CheckingGivenYearIsLeapYearTests
    {
        [TestMethod]
        public void TestLeapYear()
        {
            var yearIs = CalculateNewDate.Years.IsLeap(2000); 

            Assert.AreEqual(true, yearIs);
        }

        [TestMethod]
        public void TestNonLeapYear()
        {
            var yearIs = CalculateNewDate.Years.IsLeap(2001); 

            Assert.AreEqual(false, yearIs);
        }
    }
}
