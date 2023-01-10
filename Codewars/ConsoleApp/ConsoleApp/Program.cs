using ConsoleApp.Questions._8kyu;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"result: {FindTheSlope.Execute(new int[] {19, 3, 20, 3})}");
            Console.WriteLine($"result: {FindTheSlope.Execute(new int[] {7, 2, 7, 4})}");
            Console.WriteLine($"result: {FindTheSlope.Execute(new int[] {10, 50, 30, 150})}");
            Console.WriteLine($"result: {FindTheSlope.Execute(new int[] {15, 45, 12, 60})}");
            Console.WriteLine($"result: {FindTheSlope.Execute(new int[] {10, 20, 20, 80})}");
            Console.WriteLine($"result: {FindTheSlope.Execute(new int[] {-10, 6, -10, 3})}");
        }
    }
}
