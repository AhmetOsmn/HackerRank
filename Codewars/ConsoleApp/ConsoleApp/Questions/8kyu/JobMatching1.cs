using System;

namespace ConsoleApp.Questions._8kyu
{
    public class Candidate
    {
        public int? MinSalary { get; set; }
    }
    public class Job
    {
        public int? MaxSalary { get; set; }
    }

    public static class JobMatching1
    {
        public static bool Match(Candidate c, Job j)
        {
            if (c.MinSalary == null || j.MaxSalary == null)
            {
                throw new NotImplementedException();
            }
            var wiggleRoom = c.MinSalary * 10 / 100;
            return (c.MinSalary - wiggleRoom) <= j.MaxSalary;
        }
    }
}
