using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Questions
{
    public static class FindTheOddInt
    {
        public static int Execute()
        {
            int[] seq = { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };

            Dictionary<int, int> myDict = new Dictionary<int, int>();

            foreach (var item in seq)
            {
                if (myDict.Keys.Contains(item))
                {
                    myDict[item] += 1;
                }
                else
                {
                    myDict[item] = 1;
                }
            }

            foreach (var item in myDict)
            {
                if (item.Value % 2 != 0) return item.Key;
            }

            return 0;
        }
    }
}
