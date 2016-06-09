using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i<=100; i++)
            {
                System.Console.WriteLine(OddEven.OddEvenPrime(i));
            }
        }
    }
}
