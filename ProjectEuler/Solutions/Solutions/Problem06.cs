namespace Solutions
{
    public class Problem06
    {
        /*
         * The sum of the squares of the first ten natural numbers is,
         *
         *          1^2 + 2^2 + 3^2 + ... + 10^2 = 385
         *
         * The square of the sum of the first ten natural numbers is,
         * 
         *          (1 + 2 + 3 + ... + 10)^2 = 3025
         *
         * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is
         *
         *          3025 - 385 = 2640
         *
         * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
         */

        public static void Solution()
        {
            int limit = 100;
            int sumOfSqueares = (limit*(limit + 1)*(2*limit + 1))/6;
            int squareOfSum = Convert.ToInt32(Math.Pow((limit*(limit+1)/2),2));
            int result = squareOfSum - sumOfSqueares;

            Console.WriteLine("result: " + result);
        }
    }
}
