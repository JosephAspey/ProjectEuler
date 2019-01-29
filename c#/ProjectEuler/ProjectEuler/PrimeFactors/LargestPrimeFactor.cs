using System.Linq;

namespace ProjectEuler.PrimeFactors
{
    public class LargestPrimeFactor
    { 

        //ToDo: new is glue
        public int GetLargestPrimeFactor(long value)
        {
            var factorsRetreiver = new FactorsRetreiver();
            var factors = factorsRetreiver.GetFactors(value);

            //get prime factors from factor
            
            var primeFactorsRetriever = new PrimeFactorsRetriever();
            var primeFators = primeFactorsRetriever.GetPrimeFactors(factors);

            var highestPrimeFactor = primeFators.Max();

            return highestPrimeFactor;
        }
    }
}
