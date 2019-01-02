using System.Collections.Generic;
using System.Linq;
using ProjectEuler.FibonacciNumbers;
using Xunit;

namespace ProjectEuler.Tests.FibonacciNumbers
{
    public class FibonacciNumberHandlerTests
    {
        [Fact]
        public void ShouldReturnOne()
        {
            //Given
            var sut = new FibonacciNumberHandler();

            //When
            const int maxListCount = 1;
            var result = sut.GetFibonacciNumbers(maxListCount);

            //Then
            const int expectedValue = 1;
            Assert.Equal(expectedValue, result.First());
        }

        [Fact]
        public void ShouldNotReturnAnyFibonacciNumbersWhenTheMaxNumberIsZero()
        {
            //Given
            var sut = new FibonacciNumberHandler();

            //When
            const int maxListCount = 0;
            var result = sut.GetFibonacciNumbers(maxListCount);

            //Then
            Assert.Empty(result);
        }

        [Fact]
        public void ShouldReturnOneAndTwo()
        {
            //Given
            var sut = new FibonacciNumberHandler();

            //When
            const int maxListCount = 2;
            var result = sut.GetFibonacciNumbers(maxListCount);

            //Then
            Assert.Contains(1, result);
            Assert.Contains(2, result);
        }

        [Fact]
        public void ShouldReturnASequnceThatAdditionsThePreviousTwoNumbersInTheCollection()
        {
            //Given
            var sut = new FibonacciNumberHandler();

            //When
            const int maxListCount = 5;
            var result = sut.GetFibonacciNumbers(maxListCount);

            //Then
            Assert.Contains(1, result);
            Assert.Contains(2, result);
            Assert.Contains(3, result);
            Assert.Contains(5, result);
            Assert.Contains(8, result);
        }

        [Fact]
        public void ShouldGetEvenNumbers()
        {
            //Given
            var sut = new FibonacciNumberHandler();

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

            var result = sut.GetEvenNumbers(fibonacciNumbers);

            //Then
            Assert.Contains(2, result);
            Assert.Contains(8, result);

            const int expectedListCount = 2;
            Assert.Equal(expectedListCount, result.Count);
        }

        [Fact]
        public void ShouldNotContainOddNumbers()
        {
            //Given
            var sut = new FibonacciNumberHandler();

            //When
            var fibonacciNumbers = new List<int>
            {
                1,
                2,
                3,
            };

            var result = sut.GetEvenNumbers(fibonacciNumbers);

            //Then
            Assert.DoesNotContain(1, result);
            Assert.DoesNotContain(3, result);
        }

    }
}
