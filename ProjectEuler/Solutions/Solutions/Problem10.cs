namespace Solutions
{
    public class Problem10
    {
        /*
            The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

            Find the sum of all the primes below two million.
        */

        public static void Solution()
        {
            int limit = 2000000;
            double total = 0;
            for (int i = 2; i <= limit; i++)
            {
                if(IsPrime(i))
                    total += i;
            }

            Console.WriteLine("total: " + total);
        }

        public static bool IsPrime(int num)
        {
            if(num < 2)
                return false;

            if(num == 2)
                return true;
            
            for (int i = 2; i < Math.Sqrt(num)+1; i++)
            {
                if(num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
