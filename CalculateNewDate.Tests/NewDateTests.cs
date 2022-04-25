using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateNewDate.Tests
{
    [TestClass]
    public class NewDateTests
    {
        [TestMethod]
        public void AddDaysToGivenDate_IsSameYear_ReturnSameYear()
        {
            int day = 15, month = 4, year = 2021;
            int numberOfDays = 5;  //days will be added to above given date
            string newDate = CalculateNewDate.NewDate.AddDaysToGivenDate(day, month, year, numberOfDays);

            Assert.AreEqual("20/4/2021", newDate);
        }

        [TestMethod]
        public void AddDaysToGivenDate_IsNotSameYear_ReturnFutureYear()
        {
            int day = 15, month = 4, year = 2020;
            int numberOfDays = 900;  //days will be added to above given date
            string newDate = CalculateNewDate.NewDate.AddDaysToGivenDate(day, month, year, numberOfDays);

            Assert.AreEqual("2/10/2022", newDate);
        }

        [TestMethod]
        public void AddDaysToGivenDate_LeapYearFeb_Return29day()
        {
            int day = 28, month = 2, year = 2020;
            int numberOfDays = 1;  //days will be added to above given date
            string newDate = CalculateNewDate.NewDate.AddDaysToGivenDate(day, month, year, numberOfDays);

            Assert.AreEqual("29/2/2020", newDate);
        }
    }
}
