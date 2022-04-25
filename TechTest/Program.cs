using System;

namespace TechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // static date used for testing
                int day = 15, month = 4, year = 2021;
                int numberOfDays = 900;  //days will be added to above given date
                string newDate = CalculateNewDate.NewDate.AddDaysToGivenDate(day, month, year, numberOfDays);
                Console.WriteLine("New Date : " + newDate);
                //CalculateNewDate.Years.IsLeap
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message : ", ex.Message);
            }

        }
    }
}
