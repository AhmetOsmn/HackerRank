using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class AlternatingCase
    {
        public static string Execute(string s)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    builder.Append(s[i].ToString().ToLower());
                }
                else
                {
                    builder.Append(s[i].ToString().ToUpper());

                }
            }

            return builder.ToString();
        }
    }
}
