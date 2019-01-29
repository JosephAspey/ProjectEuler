using System.Collections.Generic;

namespace ProjectEuler.PrimeFactors
{
    public class FactorsRetreiver
    {
        public List<int> GetFactors(long value)
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
    }
}
