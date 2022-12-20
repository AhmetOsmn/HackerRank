using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class SumTheStrings
    {
        public static string Execute(string s1, string s2)
        {
            if(string.IsNullOrEmpty(s1))
            {
                s1 = "0";
            }
            if (string.IsNullOrEmpty(s2))
            {
                s2 = "0";
            }

            return (int.Parse(s1) + int.Parse(s2)).ToString();
        }

        public static string Execute_V2(string s1, string s2) => $"{(s1 == "" ? 0 : int.Parse(s1)) + (s2 == "" ? 0 : int.Parse(s2))}";
    }
}
