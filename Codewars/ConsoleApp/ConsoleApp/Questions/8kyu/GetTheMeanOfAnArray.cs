using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class GetTheMeanOfAnArray
    {
        public static int Execute(int[] marks) => (int)Math.Floor(marks.Sum() / (decimal)marks.Length);

    }
}
