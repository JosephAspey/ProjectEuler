using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.PalindromeProduct
{
    public class LargestPalindromeProduct
    {
        private readonly IPalindromeProduct _palindromeProduct;

        public LargestPalindromeProduct(IPalindromeProduct palindromeProduct)
        {
            _palindromeProduct = palindromeProduct;
        }

        public int GetLargestPalindromeFromTheProductOfTwoThreeDigitNumbers()
        {
            var products = new List<int>();

            for (var i = 999; i > 0; i--)
            {
                for (var j = 999; j > 0; j--)
                {
                    var product = i * j;
           
                    products.Add(product);           
                }
            }

            var orderProductsLargestFirst = products.OrderByDescending(x => x);

            foreach (var product in orderProductsLargestFirst)
            {
                if (_palindromeProduct.IsPalindromeProduct(product))
                {
                    return product;
                }
            }

            return 0;
        }
    }
}
