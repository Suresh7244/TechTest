using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CalculateNewDate.Constants;

namespace CalculateNewDate.Tests
{
    [TestClass]
    public class CalculateIntervalDateTests
    {
        [TestMethod]
        public void GetStartIntervalDays_RangeFromStartToGivenDate_ReturnNumOfDays()
        {
            var nov = CalculateIntervalDates.GetStartIntervalDays(15,(int)Months.Dec, 2021);
            var oct = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Nov, 2021);
            var sep = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Oct, 2021);
            var aug = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Sep, 2021);
            var jul = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Aug, 2021);
            var jun = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Jul, 2021);
            var may = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Jun, 2021);
            var apr = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.May, 2021);
            var mar = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Apr, 2021);
            var feb = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Mar, 2021);
            var febisLeap = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Mar, 2020);
            var jan = CalculateIntervalDates.GetStartIntervalDays(1, (int)Months.Feb, 2021);

            Assert.AreEqual(350, nov);
            Assert.AreEqual(305, oct);
            Assert.AreEqual(274, sep);
            Assert.AreEqual(244, aug);
            Assert.AreEqual(213, jul);
            Assert.AreEqual(182, jun);
            Assert.AreEqual(152, may);
            Assert.AreEqual(121, apr);
            Assert.AreEqual(91, mar);
            Assert.AreEqual(60, feb);
            Assert.AreEqual(61, febisLeap);
            Assert.AreEqual(32, jan);
        }
    }
}
