using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class StringTemplatesBugFixing5
    {
        public static string Execute(string[] args)
        {
            if (args.Length == 0) return "I like!";
            StringBuilder builder = new StringBuilder();
            builder.Append("I like ");

            foreach (var item in args)
            {
                builder.Append(item + ", ");
            }

            string tempStr = builder.ToString().Trim();

            return tempStr.Remove(tempStr.Length - 1, 1) + "!";
        }

        public static string Execute_V2(string[] args) => string.Format("I like {0}!", string.Join(", ", args));
    }
}
