using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSum
{
    public static class StringSum
    {
        public static string Sum(string num1, string num2)
        {
            var realnum1 = ParseToInt(num1);
            var realnum2 = ParseToInt(num2);
            var total = realnum1 + realnum2;
            return total.ToString();
        }

        private static int ParseToInt(string num)
        {
            //return string.IsNullOrEmpty(num) ? 0 : int.Parse(num);
            return IsNaturalNumber(num);

        }

        private static int IsNaturalNumber(string num)
        {
            int result = 0; 
            if(int.TryParse(num, out result) && result > 0)
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
