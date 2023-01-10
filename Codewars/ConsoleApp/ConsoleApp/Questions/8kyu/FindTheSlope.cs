namespace ConsoleApp.Questions._8kyu
{
    public static class FindTheSlope
    {
        // Slope: (y2 - y1) / (x2 - x1)

        public static string Execute(int[] points)
        {
            if (points[2] - points[0] == 0) return "undefined";

            return ((points[3] - points[1]) / (points[2] - points[0])).ToString();
        }
    }
}
