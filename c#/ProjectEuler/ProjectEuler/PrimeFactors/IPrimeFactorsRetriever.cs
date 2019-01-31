using System.Collections.Generic;

namespace ProjectEuler.PrimeFactors
{
    public interface IPrimeFactorsRetriever
    {
        List<int> GetPrimeFactors(IEnumerable<int> factors);
    }
}