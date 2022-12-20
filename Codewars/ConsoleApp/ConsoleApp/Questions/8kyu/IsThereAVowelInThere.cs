using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Questions._8kyu
{
    public static class IsThereAVowelInThere
    {
        public static object[] Execute(object[] a)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < a.Length; i++)
            {
                if (vowels.Contains(Convert.ToChar(a[i])))
                {
                    a[i] = Convert.ToChar(a[i]).ToString();
                }
            }

            return a;
        }

        public static object[] Execute_V2(object[] a) => a.Select(x => "aeiou".Contains(Convert.ToChar(x)) ? Convert.ToChar(x).ToString() : x).ToArray();

    }
}
