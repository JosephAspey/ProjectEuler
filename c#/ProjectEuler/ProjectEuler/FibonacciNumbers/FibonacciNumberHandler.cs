using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.FibonacciNumbers
{
    public class FibonacciNumberHandler : IFibonacciNumberHandler
    {
        public List<int> GetFibonacciNumbers(int maxListCount)
        {
            var fibonacciNumbers = new List<int>();

            for (var i = 1; i <= maxListCount; i++)
            {
                if (fibonacciNumbers.Any())
                {
                    var previousNumber = GetPreviousNumberInSequence(i, fibonacciNumbers);
                    var secondPreviousNumber = GetSecoundPreviousNumberInSequence(i, fibonacciNumbers);

                    var fibonacciNumber = previousNumber + secondPreviousNumber;

                    fibonacciNumbers.Add(fibonacciNumber);
                }
                else
                {
                    const int startingNumber = 1;
                    fibonacciNumbers.Add(startingNumber);
                }
            }

            AddOneToFibonacciSeqence(maxListCount, fibonacciNumbers);

            return fibonacciNumbers;
        }

        private static int GetSecoundPreviousNumberInSequence(int index, IReadOnlyList<int> fibonacciNumbers)
        {
            var secondPrevioudNumberIndex = index - 3;
            var secondPreviousNumber = 1;
            if (secondPrevioudNumberIndex >= 1)
            {
                secondPreviousNumber = fibonacciNumbers[secondPrevioudNumberIndex];
            }

            return secondPreviousNumber;
        }

        private static int GetPreviousNumberInSequence(int index, IReadOnlyList<int> fibonacciNumbers)
        {
            var previousNumnerIndex = index - 2;
            var previousNumber = fibonacciNumbers[previousNumnerIndex];
            return previousNumber;
        }

        private static void AddOneToFibonacciSeqence(int maxListCount, ICollection<int> fibonacciNumbers)
        {
            var isMaxListCountGreaterThanZero = maxListCount > 0;

            if (!fibonacciNumbers.Any() && isMaxListCountGreaterThanZero)
            {
                fibonacciNumbers.Add(1);
            }
        }

        public List<int> GetEvenNumbers(IReadOnlyCollection<int> numbers)
        {
            var evenNumbers = new List<int>();

            if (!numbers.Any()) return evenNumbers;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }

    }
}
