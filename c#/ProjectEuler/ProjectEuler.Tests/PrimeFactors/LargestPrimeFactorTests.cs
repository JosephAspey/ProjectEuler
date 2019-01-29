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
        public void ShouldGetFactorsOf10()
        {
            //Given
            var sut = new LargestPrimeFactor();

            //When
            const int numberToGetFactorsOf = 10;
            var result = sut.GetFactors(numberToGetFactorsOf);

            //Then
            Assert.Contains(1, result);
            Assert.Contains(2, result);
            Assert.Contains(5, result);
            Assert.Contains(10, result);
            Assert.True(result.Count == 4);
        }

        [Fact]
        public void ShouldGetFactorsOf15()
        {
            //Given
            var sut = new LargestPrimeFactor();

            //When
            const int numberToGetFactorsOf = 15;
            var result = sut.GetFactors(numberToGetFactorsOf);

            //Then
            Assert.Contains(1, result);
            Assert.Contains(3, result);
            Assert.Contains(5, result);
            Assert.Contains(15, result);
            Assert.True(result.Count == 4);
        }

    }
}
