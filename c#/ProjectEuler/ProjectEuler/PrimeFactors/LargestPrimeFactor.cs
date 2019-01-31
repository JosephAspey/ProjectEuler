using System.Linq;

namespace ProjectEuler.PrimeFactors
{
    public class LargestPrimeFactor
    {
        private readonly IFactorsRetreiver _factorsRetreiver;
        private readonly IPrimeFactorsRetriever _primeFactorsRetriever;

        public LargestPrimeFactor(IFactorsRetreiver factorsRetreiver, IPrimeFactorsRetriever primeFactorsRetriever)
        {
            _factorsRetreiver = factorsRetreiver;
            _primeFactorsRetriever = primeFactorsRetriever;
        }     

        public int GetLargestPrimeFactor(long value)
        {

            var factors = _factorsRetreiver.GetFactors(value);
     
            var primeFators = _primeFactorsRetriever.GetPrimeFactors(factors);

            var highestPrimeFactor = primeFators.Max();

            return highestPrimeFactor;
        }
    }
}
