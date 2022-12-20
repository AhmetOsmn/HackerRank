using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class HowManyLightsabersDoYouOwn
    {
        public static int Execute(string name)
        {
            return name == "Zach" ? 18 : 0;
        }

        public static int Execute_V2(string name, int result = 0)
        {
            if (name == "Zach")
            {
                result = 18;
            }

            return result;
        }
    }
}
