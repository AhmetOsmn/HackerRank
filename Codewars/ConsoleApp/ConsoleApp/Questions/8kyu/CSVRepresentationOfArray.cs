using System.Text;

namespace ConsoleApp.Questions._8kyu
{
    public static class CSVRepresentationOfArray
    {
        public static string Execute()
        {
            int[][] array =  {
                new[] {5, 55, 5, 5, 55},
                new[] {6, 6, 66, 23, 24},
                new[] {666, 31, 66, 33, 7}
            };

            StringBuilder builder = new StringBuilder("");

            for (int i = 0; i < array.Length; i++)
            {
                foreach (var item in array[i])
                {
                    builder.Append(item + ",");
                }
                builder.Append("\\n");
            }

            return builder.Replace(",\\n", "\\n").ToString().Substring(0, builder.Length - 2);
        }
    }
}
