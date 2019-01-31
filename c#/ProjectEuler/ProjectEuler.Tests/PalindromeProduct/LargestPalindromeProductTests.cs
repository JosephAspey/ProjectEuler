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

        public LargestPalindromeProductTests()
        {
            _palindromeProductMock = new Mock<IPalindromeProduct>();
        }

        [Fact]
        public void ShouldCallPalindromeProductToCheckIfAProductIsPalindrome()
        {
            //Given
            var sut = new LargestPalindromeProduct(_palindromeProductMock.Object);

            //When
            sut.GetLargestPalindromeProductFromThreeDigitNumbers();

            //Then
            _palindromeProductMock.Verify(x => x.IsPalindromeProduct(It.IsAny<int>()), Times.Once);
        }

    }
}
