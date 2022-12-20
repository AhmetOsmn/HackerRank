using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class RemoveFirstAndLastCharacter
    {
        public static string Execute(string s) => (s.Length >= 2) ? s.Substring(1, s.Length - 2) : "";
    }
}
