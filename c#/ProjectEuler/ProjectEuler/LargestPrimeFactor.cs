using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class LargestPrimeFactor
    { 
        public int GetLargestPrimeFactor(int value)
        {

            // get factors    
            // 'factors' are number you multiply together to get another number

            var factors = GetFactors(value);

            //get prime factors from factor
            var primeFators = GetPrimeFactors(factors);

            return 5;
        }

        public List<int> GetFactors(int value)
        {
            var factors = new List<int>();

            for (var i = 0; i <= value; i++)
            {
                for (var j = 0; j <= value; j++)
                {
                    var sum = i * j;

                    if (sum == value)
                    {
                        factors.Add(i);
                    }
                }
            }

            return factors;
        }

        public IEnumerable<int> GetPrimeFactors(IEnumerable<int> factors)
        {
            //Get prime numbers of factors

            throw new NotImplementedException();
        }

    }
}
