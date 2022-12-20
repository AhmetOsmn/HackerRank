using System;

namespace ConsoleApp.Questions
{
    public static class PlayingWithDigits
    {
        public static long Execute()
        {
            int n = 92;
            int p = 1;
            int temp = n;
            int pn = n.ToString().Length+p-1;

            double total = 0;
            while (temp > 0)
            {
                int digit = temp % 10;
                total += Math.Pow(digit, pn);
                Console.WriteLine("digit: " + digit + " pn: " + pn + " digit^pn: " + Math.Pow(digit,pn) + " total: " + total);
                temp /= 10;
                pn--;
            }

            Console.WriteLine("total: " + total + " a:" + n);
            double k = total / n;
            if (k % 1 != 0) return -1;
            return Convert.ToInt64(k);
        }
    }
}
