using System;

namespace ConsoleApp.Questions._8kyu
{
    public static class SubtractTheSum
    {
        public static string Execute(int number)
        {
            for (int i = 10; i < 200; i++)
            {
                int temp = number;

                while(temp > 100)
                {
                    temp -= SumDigits(temp);
                }
                Console.WriteLine(SumDigits(temp)); // her zaman 18 geliyor. 18 --> apple
            }

            return "apple";
        }

        public static int SumDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
