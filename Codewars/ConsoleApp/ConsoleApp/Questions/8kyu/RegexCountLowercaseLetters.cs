using System.Linq;

namespace ConsoleApp.Questions._8kyu
{
    public static class RegexCountLowercaseLetters
    {
        public static int Execute(string s) => s.Count(x => char.IsLower(x));        
    }
}
