using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    public static class OddEven
    {
        public static string OddEvenPrime(int num)
        {
            if(num%2 == 0)
            {
                return "Even";
            }

            return "Odd";
        }
    }
}
