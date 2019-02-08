namespace ProjectEuler
{
    public class SmallestMultiple
    {
        public bool IsEvenlyDivisibleWithoutAnyRemainder(int numberToDivide, int numberToDivideBy)
        {

            if (numberToDivide % numberToDivideBy  == 0)
            {
                return true;
            }

            return false;
        }
    }
}
