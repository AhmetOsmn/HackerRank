using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class AreYouPlayingBanjo
    {
        public static string Execute(string name) => (name[0] == 'r' || name[0] == 'R') ? name + " plays banjo" : name + " does not play banjo";
    }
}
