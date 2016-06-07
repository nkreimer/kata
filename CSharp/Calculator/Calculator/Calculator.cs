﻿using System;
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
            if (IsEmptyOrNullString(numbers))
                return HandleEmptyString();

            if (HasDelimiterLine(numbers))
            {
                numbers = GetNumbers(numbers);
            }


            if (HasMultipleNumbers(numbers))
            {
                return HandleMultipleNumbers(numbers);
            }
        
            return HandleOneNumber(numbers);
        }
        
        private void ParseDelimter()
        {

        }

        private static string GetNumbers (string numbers)
        {
            string[] numParts = numbers.Split(char.Parse("\n"));
            return numParts[1];
        }

        private static bool HasDelimiterLine(string numbers)
        {
            return numbers.StartsWith("//"); 
        }

        private static int HandleMultipleNumbers(string numbers)
        {
            int result = 0;
            string[] nums = numbers.Split(_delimiter.ToCharArray());
            foreach (string num in nums)
            {           
                result += HandleOneNumber(num);
            }
            return result;
        }

        private static bool HasMultipleNumbers(string numbers)
        {
            return numbers.Contains(_delimiter);
        }

        private static int HandleOneNumber(string numbers)
        {
            return int.Parse(numbers);
        }

        private static bool IsEmptyOrNullString(string s)
        {
            return string.IsNullOrEmpty(s) ? true : false;
        }

        private static int HandleEmptyString()
        {
            return 0;
        }
    }
}
