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
            if (IsPrimeNumber(num))
            {
                return "Prime";
            }
            else if (IsEvenNumber(num))
            {
                return "Even";
            }
                return "Odd";
        }

        private static bool IsEvenNumber(int num)
        {
            return num > 2 && num % 2 == 0;
        }

        private static bool IsOddNumber(int num)
        {
            return num % 2 != 0;
        }

        private static bool IsPrimeNumber(int num)
        {
            if (num < 2) return false;
            if (IsEvenNumber(num)) return false;
            var divisble = 3;
            while (divisble * divisble <= num)
            {
                if (num % divisble == 0) return false;
                divisble += 2;
            }
            return true;
        }
    }
}
