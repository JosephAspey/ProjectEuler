using System.Collections.Generic;
using ProjectEuler.PrimeFactors;
using Xunit;

namespace ProjectEuler.UnitTests.PrimeFactors
{
    public class PrimeFactorsRetrieverTests
    {
        private readonly PrimeFactorsRetriever _sut;

        public PrimeFactorsRetrieverTests()
        {
            _sut = new PrimeFactorsRetriever();
        }

        [Fact]
        public void ShouldGetThreeAndFivePrimeNumbersFromGivenFactors()
        {
            //When
            var factors = new List<int>
            {
                1,
                3,
                5,
                10
            };

            var result = _sut.GetPrimeFactors(factors);

            //Then
            Assert.Contains(3, result);
            Assert.Contains(5, result);
            Assert.True(result.Count == 2);
        }

        [Fact]
        public void ShouldGetTwoAndFivePrimeNumbersFromGivenFactors()
        {
            //When
            var factors = new List<int>
            {
                1,
                2,
                5,
                10
            };

            var result = _sut.GetPrimeFactors(factors);

            //Then
            Assert.Contains(2, result);
            Assert.Contains(5, result);
            Assert.True(result.Count == 2);
        }

        [Fact]
        public void PrimeFactorsShouldNotContain1()
        {
            //When
            var factors = new List<int>
            {
                1,
                3,
                5,
                10
            };

            var result = _sut.GetPrimeFactors(factors);

            //Then
            Assert.DoesNotContain(1, result);
        }
    }
}
