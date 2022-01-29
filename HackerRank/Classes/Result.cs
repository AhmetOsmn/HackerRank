using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.simpleArraySum
{
    public class Result
    {
        /*
            * Complete the 'miniMaxSum' function below.
            *
            * The function accepts INTEGER_ARRAY arr as parameter.
            */

        public static void miniMaxSum(List<int> arr)
        {
            long total = 0;

            List<long> results = new List<long>();
            List<long> results2 = new List<long>();

            foreach (var item in arr)
            {
                total += item;
            }

            for (int i = 0; i < arr.Count; i++)
            {
                long res = total - arr[i];
                results.Add(res);
            }

            long minResult = results.Min();
            long maxResult = results.Max();

            Console.WriteLine(minResult + " " + maxResult);
        }
    }
}
