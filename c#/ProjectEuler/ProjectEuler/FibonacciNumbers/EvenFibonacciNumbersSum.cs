using System.Collections.Generic;
using System.Linq;
using ProjectEuler.FibonacciNumbers;

namespace ProjectEuler
{
    public class EvenFibonacciNumbersSum
    {
        private readonly IFibonacciNumberHandler _fibonacciNumberHandler;

        public EvenFibonacciNumbersSum(IFibonacciNumberHandler fibonacciNumberHandler)
        {
            _fibonacciNumberHandler = fibonacciNumberHandler;
        }

        public int Calculate(int maxNumber)
        {
            var fibonacciNumbers = _fibonacciNumberHandler.GetFibonacciNumbers(maxNumber);
            var evenFibonacciNumbers = _fibonacciNumberHandler.GetEvenFibonacciNumbers(fibonacciNumbers);

            var evenFibonacciNumbersSum = 0;
            if (evenFibonacciNumbers.Any())
            {
                evenFibonacciNumbersSum = evenFibonacciNumbers.Sum();
            }

            return evenFibonacciNumbersSum;
        }
    }
}