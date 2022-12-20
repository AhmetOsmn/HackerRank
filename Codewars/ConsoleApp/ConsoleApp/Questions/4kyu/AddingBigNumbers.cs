using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions
{
    public static class AddingBigNumbers
    {
        public static string Execute()
        {
            string a = "";
            string b = "";

            BigInteger result = BigInteger.Parse(a) + BigInteger.Parse(b);
            return result.ToString();
        }
    }
}
