using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class ConvertANumberToAString
    {
        public static string Execute(int num)
        {
            return num.ToString();
        }

        public static string Execute_V2(int n) => $"{n}";
    }
}
