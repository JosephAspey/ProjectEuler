using System.Linq;
using Xunit;

namespace ProjectEuler.UnitTests
{
    /// <summary>
    /// Problem 1
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class MultiplesOfThreeAndFiveTests
    {
        [Fact]
        public void ShouldReturnAllMultipleOfThreeAndFiveBelow1000()
        {
            //When
            var result = MultiplesOfThreeAndFive.GetMultipleOfThreeAndFive(1000);

            //Then
            Assert.Contains(3, result);
            Assert.Contains(5, result);
            Assert.Contains(6, result);
            Assert.Contains(9, result);
        }

        [Fact]
        public void ShouldReturnNumberIfNumberIsAMultipleOfThree()
        {
            //When
            var result = MultiplesOfThreeAndFive.GetMultipleOfThreeAndFive(3);

            //Then
            Assert.Contains(3, result);
        }

        [Fact]
        public void ShouldReturnNumberIfNumberIsAMultipleOfFive()
        {
            //When
            var result = MultiplesOfThreeAndFive.GetMultipleOfThreeAndFive(10);

            //Then
            Assert.Contains(5, result);
        }

        [Fact]
        public void ShouldNotContainDuplicateMultipleFactors()
        {
            //When
            var result = MultiplesOfThreeAndFive.GetMultipleOfThreeAndFive(15);

            //Then
            var distinctAmount = result.Distinct().Count();
            Assert.Equal(distinctAmount, result.Count);
        }

        // Find the sum of all the multiples of 3 or 5 below 1000.
        [Fact]
        public void ShouldCalulcateTheSumOfMultplesOfThreeAndFive()
        {
            //When
            var result = MultiplesOfThreeAndFive.SumOfMultipleOfThreeAndFive(1000);

            //Then
            const int expectedSum = 233168;
            Assert.Equal(expectedSum, result);
        }
 
    }
}
