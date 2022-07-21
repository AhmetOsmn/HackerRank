namespace Solutions
{
    public class Problem03
    {
        /*
         * The prime factors of 13195 are 5, 7, 13 and 29.
         * 
         * What is the largest prime factor of the number 600851475143 ?
         */

        public static void Solution()
        {
            double limit = 600851475143;
            int squareRoot = (int)Math.Sqrt(limit);

            List<int> primeFactors = new List<int>();

            for(int i = 2; i <= squareRoot; i++)
            {
                if(limit % i == 0 && IsPrime(i))
                {
                    primeFactors.Add(i);
                }
            }

            Console.Write("result: " + primeFactors[primeFactors.Count - 1]);
        }

        public static bool IsPrime(int num)
        {
            for (int i = 2; i < num/2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
