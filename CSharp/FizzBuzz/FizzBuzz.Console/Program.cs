using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var fizzBuzz = new FizzBuzz();
                System.Console.WriteLine(fizzBuzz.GetString(i));
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Press ENTER to Quit!");

            System.Console.ReadLine();
        }
    }
}
