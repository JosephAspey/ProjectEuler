using ProjectEuler.FibonacciNumbers;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.UnitTests.FibonacciNumbers
{
    public class FibonacciNumberHandlerTests
    {
        private readonly FibonacciNumberHandler _sut;

        public FibonacciNumberHandlerTests()
        {
            _sut = new FibonacciNumberHandler();
        }

        [Fact]
        public void ShouldReturnOne()
        {
            //When
            const int maxListSize = 1;
            var result = _sut.GetFibonacciNumbers(maxListSize);

            //Then
            const int expectedValue = 1;
            Assert.Equal(expectedValue, result.First());
        }

        [Fact]
        public void ShouldNotReturnAnyFibonacciNumbersWhenTheMaxNumberIsZero()
        {

            //When
            const int maxListSize = 0;
            var result = _sut.GetFibonacciNumbers(maxListSize);

            //Then
            Assert.Empty(result);
        }

        [Fact]
        public void ShouldReturnOneAndTwo()
        {
            //When
            const int maxListSize = 2;
            var result = _sut.GetFibonacciNumbers(maxListSize);

            //Then
            Assert.Contains(1, result);
            Assert.Contains(2, result);
        }

        [Fact]
        public void ShouldReturnASequnceThatAdditionsThePreviousTwoNumbersInTheCollection()
        {
            //When
            const int maxListSize = 5;
            var result = _sut.GetFibonacciNumbers(maxListSize);

            //Then
            Assert.Contains(1, result);
            Assert.Contains(2, result);
            Assert.Contains(3, result);
            Assert.Contains(5, result);
            Assert.Contains(8, result);
        }

        [Fact]
        public void MaxValueInFibonacciSequenceShouldNotExceedFourMillion()
        {

            //When
            const int maxListSize = 6000000;
            var result = _sut.GetFibonacciNumbers(maxListSize);

            var fibonacciSequenceListSize = result.Count;
            var lastItemIndex = result[fibonacciSequenceListSize - 1];

            //Then
            var isLessThanFourMillion = lastItemIndex < 4000000;
            Assert.True(isLessThanFourMillion);
        }

        [Fact]
        public void ShouldGetEvenNumbers()
        {
            //When
            var fibonacciNumbers = new List<int>
            {
                1,
                2,
                3,
                5,
                8,
                13
            };

            var result = _sut.GetEvenNumbers(fibonacciNumbers);

            //Then
            Assert.Contains(2, result);
            Assert.Contains(8, result);

            const int expectedListCount = 2;
            Assert.Equal(expectedListCount, result.Count);
        }

        [Fact]
        public void ShouldNotContainOddNumbers()
        {
            //When
            var fibonacciNumbers = new List<int>
            {
                1,
                2,
                3,
            };

            var result = _sut.GetEvenNumbers(fibonacciNumbers);

            //Then
            Assert.DoesNotContain(1, result);
            Assert.DoesNotContain(3, result);
        }
    }
}
