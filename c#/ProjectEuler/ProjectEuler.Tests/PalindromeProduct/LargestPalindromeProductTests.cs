using Xunit;

namespace ProjectEuler.UnitTests.PalindromeProduct
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class LargestPalindromeProductTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(12)]
        [InlineData(112)]
        [InlineData(1212)]
        [InlineData(12312)]
        public void ShouldReturnFalseWhenNumberIsNotPalindrome(int number)
        {
            //Given
            var sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();

            //When
      
            var result = sut.IsPalindromeProduct(number);

            //Then
            Assert.False(result);
        }

        [Theory]
        [InlineData(11)]
        [InlineData(121)]
        [InlineData(1221)]
        [InlineData(12321)]
        public void ShouldReturnTrueWhenNumerIsPalindrome(int number)
        {
            //Given
            var sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();

            //When
            var result = sut.IsPalindromeProduct(number);

            //Then
            Assert.True(result);
        }
  
    }
}
