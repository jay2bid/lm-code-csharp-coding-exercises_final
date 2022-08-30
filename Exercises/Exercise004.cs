using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            double seconds = 1000000000;
            return dateTime.AddSeconds(seconds);
        }
    }
}
