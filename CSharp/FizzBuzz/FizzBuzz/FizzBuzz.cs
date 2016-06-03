using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {

        public string GetString(int i)
        {
            //for (int i = 100; i <= 100; i++)
            //{
            if (i % 3 == 0)
                return "Fizz";
            else
                return i.ToString();
            //}
        }
    }
}
