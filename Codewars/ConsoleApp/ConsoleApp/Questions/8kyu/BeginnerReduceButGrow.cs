using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class BeginnerReduceButGrow
    {
        public static int Execute(int[] x) => x.Aggregate((total, next) => total * next);
    }
}
