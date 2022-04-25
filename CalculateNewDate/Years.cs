namespace CalculateNewDate
{
    public class Years
    {
        // Return bool if year is leap year or not.
        public static bool IsLeap(int y)
        {
            if (y % 100 != 0 && y % 4 == 0 || y % 400 == 0)
                return true;

            return false;
        }
    }
}
