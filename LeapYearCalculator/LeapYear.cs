using System;

namespace LeapYearCalculator
{
    public class LeapYear
    {
        public bool Calculate(int year)
        {
            if (year % 400 == 0) return true;
            return false;
        }
    }
}
