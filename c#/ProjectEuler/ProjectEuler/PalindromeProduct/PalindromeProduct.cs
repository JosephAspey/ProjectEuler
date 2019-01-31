using System;

namespace ProjectEuler.PalindromeProduct
{
    public class PalindromeProduct : IPalindromeProduct
    {
        public bool IsPalindromeProduct(int number)
        {
            var numberLength = number.ToString().Length;

            if (numberLength <= 1)
            {
                return false;
            }

            var productCenterIndex = GetCentreIndexOfProduct(numberLength);
            if (!(productCenterIndex >= 1))
            {
                return false;
            }

            string firstPartOfProduct;
            string secondPartOfProduct;
            const int indexOfFirstPartProduct = 0;

            if (!IsWholeNumber(productCenterIndex))
            {
                var centerOfProductIndexRoundedDown = RoundDownFloat(productCenterIndex);
                firstPartOfProduct = GetSubStringOfProduct(number, indexOfFirstPartProduct, centerOfProductIndexRoundedDown);
                    
                var centerOfProductIndexRoundedUp = RoundUpFloat(productCenterIndex);
                secondPartOfProduct = GetSubStringOfProduct(number, centerOfProductIndexRoundedUp, centerOfProductIndexRoundedDown);
            }
            else
            {
                firstPartOfProduct = GetSubStringOfProduct(number, indexOfFirstPartProduct, (int)productCenterIndex);
                secondPartOfProduct = GetSubStringOfProduct(number, (int) productCenterIndex, (int) productCenterIndex);
            }
              
            if (secondPartOfProduct.Length >= 2)
            {
                secondPartOfProduct = ReverseString(secondPartOfProduct);
            }
         
            return firstPartOfProduct == secondPartOfProduct;
        }

        private static float GetCentreIndexOfProduct(int numberLength)
        {
            return (float)numberLength / 2;
        }

        private static bool IsWholeNumber(float productCenterIndex)
        {
            return Math.Abs(productCenterIndex % 1) < double.Epsilon;
        }

        private static int RoundDownFloat(float productCenterIndex)
        {
            return (int)Math.Floor(productCenterIndex);
        }

        private static int RoundUpFloat(float productCenterIndex)
        {
            return (int)Math.Ceiling(productCenterIndex);
        }        
        private static string GetSubStringOfProduct(int number, int startOfSubstring, int lengthOfSubstring)
        {
            return number.ToString().Substring(startOfSubstring, lengthOfSubstring);
        }

        private static string ReverseString(string secondPartOfProduct)
        {
            var arr = secondPartOfProduct.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
