using ConsoleApp.Questions;
using ConsoleApp.Questions._8kyu;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("result: " + IsThereAVowelInThere.Execute(new object[] { 118, 117, 120, 121, 117, 98, 122, 97, 120, 106, 104, 116, 113, 114, 113, 120, 106 }));
        }
    }
}
