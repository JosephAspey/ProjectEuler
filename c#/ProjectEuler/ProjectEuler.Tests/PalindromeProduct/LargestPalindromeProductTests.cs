using Xunit;

namespace ProjectEuler.UnitTests.PalindromeProduct
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class LargestPalindromeProductTests
    {
        //ToDo : Cleanup test to use constructor and pass in variables for same tests
        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotPalindrome()
        {
            //Given
            var sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();

            //When
            const int number = 112;
            var result = sut.IsPalindromeProduct(number);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotPalindromeFor1212()
        {
            //Given
            var sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();

            //When
            const int number = 1212;
            var result = sut.IsPalindromeProduct(number);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotPalindromeFor12312()
        {
            //Given
            var sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();

            //When
            const int number = 12312;
            var result = sut.IsPalindromeProduct(number);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnTrueWhenNumerIsPalindromeFor12321()
        {
            //Given
            var sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();

            //When
            const int number = 12321;
            var result = sut.IsPalindromeProduct(number);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrueWhenNumberIsPalindromFor121()
        {
            //Given
            var sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();

            //When
            const int number = 121;
            var result = sut.IsPalindromeProduct(number);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrueWhenNumberIsPalindromeFor1221()
        {
            //Given
            var sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();

            //When
            const int number = 1221;
            var result = sut.IsPalindromeProduct(number);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseWhenSuppliedNumberIsOnlyOneDigit()
        {
            //Given
            var sut = new ProjectEuler.PalindromeProduct.PalindromeProduct();

            //When
            const int number = 1;
            var result = sut.IsPalindromeProduct(number);

            //Then
            Assert.False(result);
        }

    }
}
