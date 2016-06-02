using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public static class PrimeFactors
    {
        public static List<int> Generate(this int n)
        {
            var primes = new List<int>();
            for (var divisor = 2; divisor <= Math.Sqrt(n); divisor++)
                for (; n % divisor == 0; n/=divisor)
                    primes.Add(divisor);

            if (n > 1) 
                primes.Add(n);
            
            return primes;
            //return new List<int>();
        }
    }
}
