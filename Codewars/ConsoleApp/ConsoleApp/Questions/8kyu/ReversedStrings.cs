using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class ReversedStrings
    {
        public static string Execute(string str) => new string(str.Reverse().ToArray());
    }
}
