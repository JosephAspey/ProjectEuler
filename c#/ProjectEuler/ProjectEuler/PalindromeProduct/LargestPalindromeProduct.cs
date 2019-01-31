namespace ProjectEuler.PalindromeProduct
{
    public class LargestPalindromeProduct
    {
        private readonly IPalindromeProduct _palindromeProduct;

        public LargestPalindromeProduct(IPalindromeProduct palindromeProduct)
        {
            _palindromeProduct = palindromeProduct;
        }

        public int GetLargestPalindromeProductFromThreeDigitNumbers()
        {
            var isPalindome = _palindromeProduct.IsPalindromeProduct(1);

            return 1;
        }
    }
}
