namespace Solutions
{
    public class Problem4
    {
        /*
         * IA palindromic number reads the same both ways. 
         * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
         * 
         * Find the largest palindrome made from the product of two 3-digit numbers.
         */

        public static void Solution()
        {
            for (int i = 999*999; i >= 100*100; i--)
            {
                if (IsPallindrom(i) && IsProductOfTwo3DigitNumbers(i))
                {
                    Console.WriteLine("result: " + i);
                    break;
                }
            }
        }

        public static bool IsPallindrom(int num)
        {
            string numStr = num.ToString();
            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if(numStr[i] != numStr[numStr.Length-1-i])
                    return false;
            }
            return true;
        }

        public static bool IsProductOfTwo3DigitNumbers(int num)
        {
            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    if(i*j == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
