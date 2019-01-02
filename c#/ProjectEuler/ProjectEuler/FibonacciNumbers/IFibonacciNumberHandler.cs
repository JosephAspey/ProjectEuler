using System.Collections.Generic;

namespace ProjectEuler.FibonacciNumbers
{
    public interface IFibonacciNumberHandler
    {
        List<int> GetFibonacciNumbers(int maxListCount);
        List<int> GetEvenNumbers(IReadOnlyCollection<int> numbers);
    }
}