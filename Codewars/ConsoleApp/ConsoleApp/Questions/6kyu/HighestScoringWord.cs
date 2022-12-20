using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions
{
    public static class HighestScoringWord
    {
        public static string Execute(string s)
        {
            var words = s.Split(" ");
            int max = 0;
            string result = "";

            foreach (var item in words)
            {
                int score = CalcScore(item);
                if ( score> max)
                {
                    max = score;
                    result = item;
                }
            }

            return result;
        }

        public static int CalcScore(string str)
        {
            List<char> lowers = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int score = 0;
            foreach (var item in str)
            {
                score += lowers.IndexOf(item) + 1;
            }

            return score;
        }
    }
}
