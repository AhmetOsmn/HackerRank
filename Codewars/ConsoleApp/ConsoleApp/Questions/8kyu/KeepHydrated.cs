using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class KeepHydrated
    {
        public static int Execute(double time) => time == 0 ? 0 : (int)Math.Floor(time/2);
    }
}
