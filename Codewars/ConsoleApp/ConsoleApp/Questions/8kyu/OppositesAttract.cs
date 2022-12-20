using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class OppositesAttract
    {
        public static bool Execute(int flower1, int flower2)
            => ((flower1 % 2 == 0) && (flower2 % 2 == 1) || (flower1 % 2 == 1) && (flower2 % 2 == 0));

        public static bool Execute_V2(int flower1, int flower2)
            => (flower1 % 2 != flower2 % 2);
    }
}
