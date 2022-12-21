using ConsoleApp.Questions;
using ConsoleApp.Questions._8kyu;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"result: {RegexCountLowercaseLetters.Execute("abc")}");
            Console.WriteLine($"result: {RegexCountLowercaseLetters.Execute("abcABC123")}");
            Console.WriteLine($"result: {RegexCountLowercaseLetters.Execute("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~")}");
            Console.WriteLine($"result: {RegexCountLowercaseLetters.Execute("")}");
            Console.WriteLine($"result: {RegexCountLowercaseLetters.Execute("ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~")}");
            Console.WriteLine($"result: {RegexCountLowercaseLetters.Execute("abcdefghijklmnopqrstuvwxyz")}");
        }
    }
}
