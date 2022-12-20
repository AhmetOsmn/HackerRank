using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class SuperDuperEasy
    {
        public static string Execute(String a)
        {
			try
			{
				return ((Convert.ToDouble(a) * 50) + 6).ToString();
			}
			catch (Exception)
			{
				return "Error";
			}
        }
    }
}
