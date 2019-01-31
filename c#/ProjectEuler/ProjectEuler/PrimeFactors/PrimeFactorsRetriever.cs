using System;
using System.Collections.Generic;

namespace ProjectEuler.PrimeFactors
{
    public class PrimeFactorsRetriever : IPrimeFactorsRetriever
    {
        public List<int> GetPrimeFactors(IEnumerable<int> factors)
        {
            var primeFactors = new List<int>();

            foreach (var factor in factors)
            {
                if (IsPrimeNumber(factor))
                {
                    primeFactors.Add(factor);
                }
            }

            return primeFactors;
        }

        private static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (var i = 2; i < limit; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
