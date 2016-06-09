using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStats
{
    public static class CalcStats
    {
        public enum CalcStatKeys
        {
            Minimum = 1, Maximum = 2, ElementCount = 3, Average = 4
        }

        public static string NumberStats(IList<int> numbers, CalcStatKeys keys)
        {
            switch(keys)
            {
                case CalcStatKeys.Minimum:
                    return GetMinValue(numbers);
                case CalcStatKeys.Maximum:
                    return GetMaxValue(numbers);
                case CalcStatKeys.ElementCount:
                    return GetElementCount(numbers);
                case CalcStatKeys.Average:
                    return GetAverageValue(numbers);              
            }
            return null;
        }

        private static string GetMinValue(IList<int> numbers)
        {
            return numbers.Min().ToString();
        }

        private static string GetMaxValue(IList<int> numbers)
        {
            return numbers.Max().ToString();
        }

        private static string GetElementCount(IList<int> numbers)
        {
            return numbers.Count().ToString();
        }

        private static string GetAverageValue(IList<int> numbers)
        {
            return (numbers.Sum() / numbers.Count()).ToString();
        }
    }
}
