using System;

namespace LeapYearCalculator
{
    public class LeapYear
    {
        public bool Calculate(int year)
        {
            
            if(year %100 == 0 && year% 400 != 0)return false;
            else if (year % 400 == 0 || year % 4 == 0) return true;
            return false;
        }
    }
}
