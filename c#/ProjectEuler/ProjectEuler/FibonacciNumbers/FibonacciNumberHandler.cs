using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.FibonacciNumbers
{
    public class FibonacciNumberHandler : IFibonacciNumberHandler
    {
        public List<int> GetFibonacciNumbers(int maxNumber)
        {
            var fibonacciNumbers = new List<int>();

            for (var i = 1; i < maxNumber; i++)
            {
                if (fibonacciNumbers.Any())
                {
                    var previousNumnerIndex = i - 2;
                    var previousNumber = fibonacciNumbers[previousNumnerIndex];

                    var previousNumber2Index = i - 3;
                    var previousNumber2 = 1;
                    if (previousNumber2Index >= 1)
                    {
                        previousNumber2 = fibonacciNumbers[previousNumber2Index];
                    }

                    var fibonacciNumber = previousNumber + previousNumber2;

                    fibonacciNumbers.Add(fibonacciNumber);
                }
                else
                {
                    const int startingNumber = 1;
                    fibonacciNumbers.Add(startingNumber);
                }
            }

            return fibonacciNumbers;
        }

        public List<int> GetEvenFibonacciNumbers(IReadOnlyCollection<int> fibonacciNumbers)
        {
            var evenFibonacciNumbers = new List<int>();

            if (!fibonacciNumbers.Any()) return evenFibonacciNumbers;

            foreach (var fibonacciNumber in fibonacciNumbers)
            {
                if (fibonacciNumber % 2 == 0)
                {
                    evenFibonacciNumbers.Add(fibonacciNumber);
                }
            }

            return evenFibonacciNumbers;
        }

    }
}
