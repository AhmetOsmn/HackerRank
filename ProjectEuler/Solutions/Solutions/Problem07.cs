namespace Solutions
{
    public class Problem07
    {
        /*
        * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        *
        * What is the 10 001st prime number?
        */

        public static void Solution()
        {
            int primeCount = 0;
            int number = 2;
            while(true)
            {
                if(IsPrime(number))
                    primeCount++;
                
                if(primeCount == 10001)
                {
                    Console.WriteLine("10001. prime number: " + number);
                    break;
                }

                number += 1;
            }
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
