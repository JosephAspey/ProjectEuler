using ProjectEuler.PrimeFactors;
using Xunit;

namespace ProjectEuler.Tests
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
        [Fact]
        public void ShouldReturn29AsTheHighestPrimeFactorOf13195()
        {
            //Given
            var sut = new LargestPrimeFactor();

            //When
            var result = sut.GetLargestPrimeFactor(13195);

            //Then
            var expectedHightPrimeFactor = 29;
            Assert.Equal(expectedHightPrimeFactor, result);
        }

    }
}
