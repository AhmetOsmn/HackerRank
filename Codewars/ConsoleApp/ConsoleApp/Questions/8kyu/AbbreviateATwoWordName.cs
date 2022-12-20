using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class AbbreviateATwoWordName
    {
        public static string Execute(string name) => name.ToUpper().Split(" ")[0][0] + "." + name.ToUpper().Split(" ")[1][0];
    }
}
