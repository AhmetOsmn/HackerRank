using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions
{
    public static class SumStringsAsNumbers
    {
        public static string Execute()
        {
            string a = "";
            string b = "";

            if (a == "")
            {
                a = 0.ToString();
            }
            if (b == "")
            {
                b = 0.ToString();
            }
            BigInteger result = 0;
            try
            {
                result = BigInteger.Parse(a) + BigInteger.Parse(b);
            }
            catch (Exception)
            {

                return a + "+" + b;
            }

            return result.ToString();
        }
    }
}
