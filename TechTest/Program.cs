using System;

namespace TechTest
{
    class Program
    {
        // Find values of newDay and newMonth from
        // offset of result newYear.
        static int newMonth, newDay;
        enum Months : int { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        enum YearIs : int { NonLeapYear = 365, LeapYear}
        // Return if year is leap year or not.
        static bool IsLeap(int y)
        {
            if (y % 100 != 0 && y % 4 == 0 || y % 400 == 0)
                return true;

            return false;
        }

        // Given a date, returns number of days elapsed
        // from the beginning of the current year (1st
        // jan).
        static int GetStartIntervalDays(int day, int month, int year)
        {
            int includeStartingDate = day;

            if (month - 1 == (int)Months.Nov)
                includeStartingDate += 335;
            if (month - 1 == (int)Months.Oct)
                includeStartingDate += 304;
            if (month - 1 == (int)Months.Sep)
                includeStartingDate += 273;
            if (month - 1 == (int)Months.Aug)
                includeStartingDate += 243;
            if (month - 1 == (int)Months.Jul)
                includeStartingDate += 212;
            if (month - 1 == (int)Months.Jun)
                includeStartingDate += 181;
            if (month - 1 == (int)Months.May)
                includeStartingDate += 151;
            if (month - 1 == (int)Months.Apr)
                includeStartingDate += 120;
            if (month - 1 == (int)Months.Mar)
                includeStartingDate += 90;
            if (month - 1 == (int)Months.Feb)
                includeStartingDate += 59;
            if (month - 1 == (int)Months.Jan)
                includeStartingDate += 31;

            if (IsLeap(year) && month > (int)Months.Feb)
                includeStartingDate += 1;

            return includeStartingDate;
        }

        // Given a year and days elapsed in it, finds
        // date by storing results in newDay and newMonth.
        static void SetRevOffsetDays(int offset, int newYear)
        {
            //number of days in month 
            int[] month = { 0, 31, 28, 31, 30, 31, 30,
                    31, 31, 30, 31, 30, 31 };

            if (IsLeap(newYear))
                month[2] = 29;
            int i;
            for (i = 1; i <= 12; i++)
            {
                if (offset <= month[i])
                    break;
                offset = offset - month[i];
            }

            newDay = offset;
            newMonth = i;
        }

        // Add numberOfDays to the given date.
        static void AddDaysToGivenDate(int day, int month, int year, int numberOfDays)
        {
            // offset1 - days from beginning to given date 
            // ex: 01/Jan/2021  ==> 15/March/2021;
            int offset1 = GetStartIntervalDays(day, month, year);
            int remDays = IsLeap(year) ? ((int)YearIs.LeapYear - offset1) : ((int)YearIs.NonLeapYear - offset1);

            // newYear is going to store result year and
            // offset2 is going to store offset days
            // in result year.
            int newYear, offset2 = 0;
            if (numberOfDays <= remDays)
            {
                newYear = year;
                offset2 = offset1 + numberOfDays;
            }
            else
            {
                // numberOfDays may store thousands of days.
                // We find correct year and offset
                // in the year.
                numberOfDays -= remDays;
                newYear = year + 1;
                int newNextYear = IsLeap(newYear) ? (int)YearIs.LeapYear : (int)YearIs.NonLeapYear;
                while (numberOfDays >= newNextYear)
                {
                    numberOfDays -= newNextYear;
                    newYear++;
                    newNextYear = IsLeap(newYear) ? (int)YearIs.LeapYear : (int)YearIs.NonLeapYear;
                }
                offset2 = numberOfDays;
            }
            SetRevOffsetDays(offset2, newYear);
            Console.WriteLine("New Date : " + newDay + "/" + newMonth + "/" + newYear);
        }
        static void Main(string[] args)
        {
            try
            {
                // static date used for testing
                int day = 15, month = 4, year = 2021;
                int numberOfDays = 5;  //days will be added to above given date
                AddDaysToGivenDate(day, month, year, numberOfDays);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message : ", ex.Message);
            }
            
        }
    }
}
