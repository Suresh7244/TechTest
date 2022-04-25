using static CalculateNewDate.Constants;
using static CalculateNewDate.Years;

namespace CalculateNewDate
{
    public class CalculateIntervalDates
    {
        // Given a date, returns number of days elapsed
        // from the beginning of the current year (1st
        // jan).
        public static int GetStartIntervalDays(int day, int month, int year)
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
    }
}
