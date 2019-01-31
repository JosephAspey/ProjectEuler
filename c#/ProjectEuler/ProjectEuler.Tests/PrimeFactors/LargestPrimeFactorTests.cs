using System.Collections.Generic;
using Moq;
using ProjectEuler.PrimeFactors;
using Xunit;

namespace ProjectEuler.UnitTests.PrimeFactors
{
    /// <summary>
    /// Problem 3
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// 
    /// Help: https://www.mathsisfun.com/prime-factorization.html
    ///
    /// "Factors" are the numbers you multiply together to get another number:
    /// 
    /// A Prime Number can be divided exactly only by 1 or itself.
    /// And it must be a whole number greater than 1.
    /// </summary>
    public class LargestPrimeFactorTests
    {

        private readonly Mock<IFactorsRetreiver> _factorsRetreiverMock;
        private readonly Mock<IPrimeFactorsRetriever> _primeFactorsRetrieverMock;

        public LargestPrimeFactorTests()
        {
            _factorsRetreiverMock = new Mock<IFactorsRetreiver>();
            _primeFactorsRetrieverMock = new Mock<IPrimeFactorsRetriever>();
        }

        [Fact]
        public void ShouldReturnTheLargestPrimeFactor()
        {
            //Given
            var getFactorsMockResult = new List<int>();
            _factorsRetreiverMock.Setup(x => x.GetFactors(It.IsAny<int>())).Returns(getFactorsMockResult);

            var getPrimeFactorsMockResult = new List<int>
            {
                5, 7, 13, 29
            };
            _primeFactorsRetrieverMock.Setup(x => x.GetPrimeFactors(It.IsAny<List<int>>()))
                .Returns(getPrimeFactorsMockResult);

            var sut = new LargestPrimeFactor(_factorsRetreiverMock.Object, _primeFactorsRetrieverMock.Object);

            //When
            var result = sut.GetLargestPrimeFactor(13195);

            //Then
            const int expectedHighestPrimeFactor = 29;
            Assert.Equal(expectedHighestPrimeFactor, result);
        }

    }
}
