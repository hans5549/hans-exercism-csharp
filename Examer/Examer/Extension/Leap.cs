namespace Examer.Extension
{
    public static class Leap
    {
        public static bool IsLeapYear(int year)
        {
            if (year < 0)
            {
                throw new NotImplementedException("You need to implement this method.");
            }

            if ((year % 4) == 0)
            {
                if ((year % 100) == 0)
                {
                    if ((year % 400) == 0)
                    {
                        return true; 
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
