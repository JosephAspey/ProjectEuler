using Moq;
using ProjectEuler.PalindromeProduct;
using Xunit;

namespace ProjectEuler.UnitTests.PalindromeProduct
{
    public class LargestPalindromeProductTests
    {
        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>

        private readonly Mock<IPalindromeProduct> _palindromeProductMock;

        private readonly LargestPalindromeProduct _sut;

        public LargestPalindromeProductTests()
        {
            _palindromeProductMock = new Mock<IPalindromeProduct>();
            _sut = new LargestPalindromeProduct(_palindromeProductMock.Object);
        }

        [Fact]
        public void ShouldCallPalindromeProductToCheckIfAProductIsPalindrome()
        {
            //When
            _sut.GetLargestPalindromeFromTheProductOfTwoThreeDigitNumbers();

            //Then
            _palindromeProductMock.Verify(x => x.IsPalindromeProduct(It.IsAny<int>()), Times.AtLeastOnce);
        }

        [Fact]
        public void ShouldGetTheLargestPalindromeMadeFromTheProductOfTwoThreeDigitNumbers()
        {
            //Given
            _palindromeProductMock.Setup(x => x.IsPalindromeProduct(906609)).Returns(true); 

            //When
            var result = _sut.GetLargestPalindromeFromTheProductOfTwoThreeDigitNumbers();

            //Then
            const int expectedResult = 906609; //993 * 913
            Assert.Equal(expectedResult, result);
        }

    }
}
