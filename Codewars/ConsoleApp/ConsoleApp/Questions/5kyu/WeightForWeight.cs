using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions
{
    public static class WeightForWeight
    {
        public static string Execute(string strng)
        {
            if (string.IsNullOrEmpty(strng)) return "";

            Dictionary<string, long> dict = new Dictionary<string, long>();
            Dictionary<string, int> freqs = new Dictionary<string, int>();
            var numbers = strng.Split(" ");

            string result = "";
            foreach (var item in numbers)
            {
                dict[item] = GetWeight(Convert.ToInt64(item));

                if (freqs.Keys.Contains(item))
                {
                    freqs[item]++;
                }
                else
                {
                    freqs[item] = 1;
                }
            }

            dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            var temp = dict.GroupBy(x => x.Value).ToList();

            for(int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Count() > 1)
                {
                    var hede = temp[i].OrderBy(x => x.Key).ToList();
                    foreach (var item in hede)
                    {
                        for(int j = 0; j < freqs[item.Key];j++)
                        {
                            result += item.Key + " ";
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < freqs[temp[i].First().Key]; j++)
                    {
                        result += temp[i].First().Key + " ";
                    }
                }
            }

            return result.Trim();
        }

        public static long GetWeight(long number)
        {
            long w = 0;
            while(number > 0)
            {
                w += number % 10;
                number /= 10;
            }
            return w;
        }
    }
}
