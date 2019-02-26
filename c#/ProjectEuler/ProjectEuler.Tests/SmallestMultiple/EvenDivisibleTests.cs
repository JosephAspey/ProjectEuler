using ProjectEuler.SmallestMultiple;
using Xunit;

namespace ProjectEuler.UnitTests
{

    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class EventDivisibleTests
    {
        private readonly EvenDivisible _sut;

        public EventDivisibleTests()
        {
            _sut = new EvenDivisible();
        }

        [Fact]
        public void ShouldReturnTrueWhenNumberIsEvenlyDivisibleWithoutAnyRemainder()
        {
            //Given        
            const int numberToDivide = 2520;
            const int numberToDivideBy = 2;

            //When
            var result = _sut.IsEvenlyDivisibleWithoutAnyRemainder(numberToDivide, numberToDivideBy);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotEvenlyDivisbleWithoutAnyRemainer()
        {
            //Given
            const int numberToDivide = 5;
            const int numberToDivideBy = 3;

            //When
            var result = _sut.IsEvenlyDivisibleWithoutAnyRemainder(numberToDivide, numberToDivideBy);

            //Then
            Assert.False(result);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]

        public void ShouldReturnTrueAs2520CanBeDividedByEachNumberFrom1To10WithoutAnyRemainder(int numberToDivideBy)
        {
            //Given
            const int numberToDivide = 2520;

            //When
            var result = _sut.IsEvenlyDivisibleWithoutAnyRemainder(numberToDivide, numberToDivideBy);

            //Then
            Assert.True(result);
        }
    }
}
