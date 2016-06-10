using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public static class LeapYear
    {
        public static Boolean IsLeapYear(string year)
        {
            /*
                A leap year is defined as one that is divisible by 4,
            but is not otherwise divisible by 100 unless it is
            also divisble by 400.
            */
            var intYear = int.Parse(year);

            if (intYear % 4 == 0)
                if (intYear % 100 > 0 || intYear % 400 == 0)
                        return true;
            return false;
        }
    }
}
