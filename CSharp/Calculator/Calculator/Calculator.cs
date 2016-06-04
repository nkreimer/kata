using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {

        private static string _delimiter = ",";

        public static int Add(string numbers)
        {
            if(IsEmptyString(numbers))
                return HandleEmptyString();

            if (HasMultipleNumbers(numbers))
            {
                return HandleMultipleNumbers(numbers);
            }
        
            return HandleOneNumber(numbers);
        }

        private static int HandleMultipleNumbers(string numbers)
        {
            string[] nums = numbers.Split(_delimiter.ToCharArray());
            return HandleOneNumber(nums[0]) + HandleOneNumber(nums[1]);
        }

        private static bool HasMultipleNumbers(string numbers)
        {
            return numbers.Contains(_delimiter);
        }

        private static int HandleOneNumber(string numbers)
        {
            return int.Parse(numbers);
        }

        private static bool IsEmptyString(string s)
        {
            if(s.Length == 0)
            {
                return true;
            }
            return false;
        }

        private static int HandleEmptyString()
        {
            return 0;
        }
    }
}
