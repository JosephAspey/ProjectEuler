using System.Collections.Generic;

namespace ProjectEuler.FibonacciNumbers
{
    public interface IFibonacciNumberHandler
    {
        List<int> GetFibonacciNumbers(int maxListSize);
        List<int> GetEvenNumbers(IReadOnlyCollection<int> numbers);
    }
}