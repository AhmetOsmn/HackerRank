using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class TakeAnArrowToTheKneeFunctionally
    {
        public static string Execute(int[] arr)
        {
            return string.Join("", arr.Select(number  => (char)number).ToArray());
        }
    }
}
