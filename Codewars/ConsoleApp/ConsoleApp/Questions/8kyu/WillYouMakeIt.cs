using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class WillYouMakeIt
    {
        public static bool Execute(uint distanceToPump, uint mpg, uint fuelLeft) => distanceToPump <= mpg * fuelLeft ? true : false;
    }
}
