using ProjectEuler.PrimeFactors;
using Xunit;

namespace ProjectEuler.UnitTests.PrimeFactors
{
    public class FactorsRetreiverTests
    {
        private readonly FactorsRetreiver _sut; 

        public FactorsRetreiverTests()
        {
            _sut = new FactorsRetreiver();
        }

        [Fact]
        public void ShouldGetFactorsOf15()
        {
            //Given


            //When
            const int numberToGetFactorsOf = 15;
            var result = _sut.GetFactors(numberToGetFactorsOf);

            //Then
            Assert.Contains(1, result);
            Assert.Contains(3, result);
            Assert.Contains(5, result);
            Assert.Contains(15, result);
            Assert.True(result.Count == 4);
        }

        [Fact]
        public void ShouldGetFactorsOf10()
        {
            //When
            const int numberToGetFactorsOf = 10;
            var result = _sut.GetFactors(numberToGetFactorsOf);

            //Then
            Assert.Contains(1, result);
            Assert.Contains(2, result);
            Assert.Contains(5, result);
            Assert.Contains(10, result);
            Assert.True(result.Count == 4);
        }
    }
}
