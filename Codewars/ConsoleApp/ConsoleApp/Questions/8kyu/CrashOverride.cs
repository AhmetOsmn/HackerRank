using System;
using System.Collections.Generic;

namespace ConsoleApp.Questions._8kyu
{
    public static class CrashOverride
    {
        private static Dictionary<string, string> FirstName;
        private static Dictionary<string, string> Surname;
        public static string Execute(string fName, string lName)
        {
            try
            {
                return $"{FirstName[fName[0].ToString()]} {Surname[lName[0].ToString()]}";
            }
            catch (Exception ex)
            {
                return "Your name must start with a letter from A - Z.";
            }
        }
    }
}
