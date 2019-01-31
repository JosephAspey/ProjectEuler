using System.Collections.Generic;

namespace ProjectEuler.PrimeFactors
{
    public interface IFactorsRetreiver
    {
        List<int> GetFactors(long value);
    }
}