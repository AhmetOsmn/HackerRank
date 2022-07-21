namespace Solutions
{
    public class Problem05
    {
        /*
         * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         * 
         * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         */

        public static void Solution()
        {
            int result = 2520;
         
            while(!IsDivisible(result))
            {
                result += 2520;
            }

            Console.WriteLine("result: " + result);
        }

        public static bool IsDivisible(int num)
        {
            int[] factors = {11,12,13,14,15,16,17,18,19,20};
            
            foreach (int item in factors)
            {
                if(num % item != 0)
                    return false;
            }
            return true;
        }
    }
}
