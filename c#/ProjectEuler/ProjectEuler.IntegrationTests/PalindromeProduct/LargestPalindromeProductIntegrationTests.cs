using ProjectEuler.PalindromeProduct;
using Xunit;

namespace ProjectEuler.IntegrationTests.PalindromeProduct
{
    /// <summary>
    /// Problem 4
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class LargestPalindromeProductIntegrationTests
    {

        private readonly LargestPalindromeProduct _sut;

        public LargestPalindromeProductIntegrationTests()
        {
            var palindromeProduct = new ProjectEuler.PalindromeProduct.PalindromeProduct();
            _sut = new LargestPalindromeProduct(palindromeProduct);
        }

        [Fact]
        public void ShouldGetTheLargestPalindromeMadeFromTheProductOfTwoThreeDigitNumbers()
        {
            //When
            var result = _sut.GetLargestPalindromeFromTheProductOfTwoThreeDigitNumbers();

            //Then
            const int expectedResult = 906609;
            Assert.Equal(expectedResult, result);
        }

    }
}
