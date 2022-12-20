using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions._8kyu
{
    public static class CalculateBMI
    {
        public static string Execute(double weight, double height)
        {
            double bmi = weight / (height * height);
            if (bmi <= 18.5) return "Underweight";
            if (bmi <= 25.0) return "Normal";
            if (bmi <= 30.0) return "Overweight";
            if (bmi > 30.0) return "Obese";
            return "";
        }

        public static string Execute_V2(double w, double h)
            => (w = w / h / h) > 30 ? "Obese" : w > 25 ? "Overweight" : w > 18.5 ? "Normal" : "Underweight";

    }
}
