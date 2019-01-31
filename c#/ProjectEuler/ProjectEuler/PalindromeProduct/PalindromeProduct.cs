using System;

namespace ProjectEuler.PalindromeProduct
{
    public class PalindromeProduct
    {
        public bool IsPalindromeProduct(int number)
        {
            var numberLength = number.ToString().Length;

            if (numberLength <= 1)
            {
                return false;
            }

            //split in centre
            var productCenterLenght = (float)numberLength / 2;

            if (productCenterLenght >= 1)
            {
                //reverse

                //if odd length e.g. 3, 5 - round down and split
                var isWholeNumber = Math.Abs(productCenterLenght % 1) < double.Epsilon;

                string firstPartOfProduct = "";
                string secondPartOfProduct = "";

                if (!isWholeNumber)
                {
                    //round down to get first part - middle digit is disregarded
                    var centerOfProductLengthRoundedDown = (int)Math.Floor(productCenterLenght);
                    firstPartOfProduct = number.ToString().Substring(0 , centerOfProductLengthRoundedDown);
                    
                    //round up - to split and get after
                    var centerOfProductRoundedUp = (int)Math.Ceiling(productCenterLenght);
                    secondPartOfProduct = number.ToString().Substring(centerOfProductRoundedUp, centerOfProductLengthRoundedDown);
                }
                else
                {
                    firstPartOfProduct = number.ToString().Substring(0, (int)productCenterLenght);
                    secondPartOfProduct =
                        number.ToString().Substring((int) productCenterLenght, (int) productCenterLenght);
                }
               
                //if string length > 2
                var secondPartOfProductReversed = "";
                if (secondPartOfProduct.Length >= 2)
                {
                    var arr = secondPartOfProduct.ToCharArray();
                    Array.Reverse(arr);
                    secondPartOfProductReversed = new string(arr);
                }
                else
                {
                    secondPartOfProductReversed = secondPartOfProduct;
                }

                if (firstPartOfProduct == secondPartOfProductReversed)
                {
                    return true;
                }                        
            }

            return false;
        }
    }
}
