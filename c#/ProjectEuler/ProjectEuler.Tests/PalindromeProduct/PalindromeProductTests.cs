using Xunit;

namespace ProjectEuler.UnitTests.PalindromeProduct
{
    public class PalindromeProductTests
    {
        private readonly ProjectEuler.PalindromeProduct.PalindromeProduct _sut;

        public PalindromeProductTests()
        {
            _sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(12)]
        [InlineData(112)]
        [InlineData(1212)]
        [InlineData(12312)]
        public void ShouldReturnFalseWhenNumberIsNotPalindrome(int number)
        {
            //When     
            var result = _sut.IsPalindromeProduct(number);

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
            //When
            var result = _sut.IsPalindromeProduct(number);

            //Then
            Assert.True(result);
        }
    }
}
