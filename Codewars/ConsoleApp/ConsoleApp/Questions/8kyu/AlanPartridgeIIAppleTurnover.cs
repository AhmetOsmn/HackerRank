using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class AlanPartridgeIIAppleTurnover
    {
        public static string Execute(object n)
        {
			try
			{
                int temp = Convert.ToInt32(n);

                return (temp * temp) > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
			}
			catch (Exception)
			{
                return "";
			}
        }
    }
}
