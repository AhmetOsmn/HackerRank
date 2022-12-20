using System;
using System.Linq;

namespace ConsoleApp.Questions
{
    public static class AreTheyTheSame
    {
        public static bool Execute()
        {
            int[] a = { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };

            if ((a == null) || (b == null)) return false;
            int[] aa = a.Select(s => s * s).ToArray();
            Array.Sort(aa);
            Array.Sort(b);
            return aa.SequenceEqual(b);
        }
    }
}
