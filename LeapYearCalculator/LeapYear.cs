using System;

namespace LeapYearCalculator
{
    public class LeapYear
    {
        private bool DivisibleBy4(int year)
        {
            return year % 4 == 0;
        }

        private bool DivisibleBy100(int year)
        {
            return year % 100 == 0;
        }

        private bool DivisibleBy400(int year)
        {
            return year % 400 == 0;
        }

        public bool Calculate(int year)
        {
            if (DivisibleBy100(year) && !DivisibleBy400(year)) return false;
            else if (DivisibleBy400(year) || DivisibleBy4(year)) return true;
            return false;
        }
    }
}
