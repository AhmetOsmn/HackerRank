using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class ParseNiceIntFromCharProblem
    {
        public static int Execute(string inputString) => int.Parse(inputString[0].ToString());

        public static int Execute_V2(string inputString) => inputString[0] - '0';
    }
}
