using System.Collections.Generic;

namespace ProjectEuler.FibonacciNumbers
{
    public interface IFibonacciNumberHandler
    {
        List<int> GetFibonacciNumbers(int maxNumber);
        List<int> GetEvenFibonacciNumbers(IReadOnlyCollection<int> fibonacciNumbers);
    }
}