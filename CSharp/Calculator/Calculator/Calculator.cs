using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            if(IsEmptyString(numbers))
              return HandleEmptyString();

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
