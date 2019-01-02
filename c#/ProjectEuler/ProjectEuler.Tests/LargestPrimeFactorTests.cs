using Xunit;

namespace ProjectEuler.Tests
{

    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class LargestPrimeFactorTests
    {
        [Fact]
        public void ShouldGetTheLargestPrimeFactor()
        {
            //Given
            var sut = new LargestPrimeFactor();

            //When
            var result = sut.Get(13195);

            //Then
            const int expectedResult = 29;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ShouldGetPrimeNumbers()
        {
            //Given

            //When

            //Then
        }
    }
}
