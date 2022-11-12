using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions
{
    public static class BuildAPileOfCubes
    {
        public static long Execute()
        {
            long m = 24723578342962;

            //double n = ((-1) + Math.Sqrt(1 + (8 * Math.Sqrt(m))))/2;

            double n = 0;

            while (true)
            {
                if (n > Math.Sqrt(m)) return -1;
                if (n * (n + 1) == 2 * Math.Sqrt(m)) break;
                n++;
            }

            return Convert.ToInt64(n);
        }
    }
}