using System;
using System.Linq;

namespace ConsoleApp.Questions._8kyu
{
    public static class DifferenceOfVolumesOfCuboids
    {
        public static int Execute(int[] a, int[] b) 
            => 
            Math.Abs(
                a.AsEnumerable().Aggregate((total, next) => total * next) - 
                b.AsEnumerable().Aggregate((total, next) => total * next));

    }
}
