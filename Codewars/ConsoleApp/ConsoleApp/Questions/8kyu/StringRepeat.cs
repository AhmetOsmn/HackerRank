using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class StringRepeat
    {
        public static string Execute(int n, string s) => string.Concat(Enumerable.Repeat(s, n));
    }
}
