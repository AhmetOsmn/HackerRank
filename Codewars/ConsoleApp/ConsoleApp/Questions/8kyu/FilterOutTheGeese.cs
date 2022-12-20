using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Questions._8kyu
{
    public static class FilterOutTheGeese
    {
        public static IEnumerable<string> Execute(IEnumerable<string> birds)
        {
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            return birds.Except(geese);
        }

        public static IEnumerable<string> Execute_V2(IEnumerable<string> birds) => birds.Except(new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" });

    }
}
