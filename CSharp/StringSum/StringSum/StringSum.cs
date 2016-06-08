using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSum
{
    public static class StringSum
    {
        public static int Sum(string num1, string num2)
        {
            var realnum1 = ParseToInt(num1);
            var realnum2 = ParseToInt(num2);
            var total = realnum1 + realnum2;
            return total;
        }

        private static int ParseToInt(string num)
        {
            return int.Parse(num);
        }
    }
}
