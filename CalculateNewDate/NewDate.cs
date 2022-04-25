using System;
using static CalculateNewDate.Constants;
using static CalculateNewDate.Years;

namespace CalculateNewDate
{
    public class NewDate
    {       
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
        public static string AddDaysToGivenDate(int day, int month, int year, int numberOfDays)
        {
            // offset1 - days from beginning to given date 
            // ex: 01/Jan/2021  ==> 15/March/2021;
            int offset1 = CalculateIntervalDates.GetStartIntervalDays(day, month, year);
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
            return $"{ newDay}/{ newMonth }/{ newYear}";
        }
    }
}
