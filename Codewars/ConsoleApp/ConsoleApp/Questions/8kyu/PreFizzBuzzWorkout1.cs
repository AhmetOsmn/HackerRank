using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Questions._8kyu
{
    public static class PreFizzBuzzWorkout1
    {
        public static int[] Execute(int n)
        {
           List<int> numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i); ;
            }

            return numbers.ToArray();
        }

        public static int[] Execute_V2(int n) => Enumerable.Range(1, n).ToArray();
    }
}
