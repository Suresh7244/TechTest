namespace CalculateNewDate
{
    public class Constants
    {
        public enum Months : int { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        public enum YearIs : int { NonLeapYear = 365, LeapYear }

        // Find values of newDay and newMonth from
        // offset of result newYear.
        public static int newMonth, newDay;
    }
}
