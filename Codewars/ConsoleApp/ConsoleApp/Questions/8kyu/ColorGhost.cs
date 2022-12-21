using System;

namespace ConsoleApp.Questions._8kyu
{
    public class ColorGhost
    {
        private readonly string[] _colors = { "white", "yellow", "purple", "red" };

        private string _color = string.Empty;

        public ColorGhost()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, 4);
            _color = _colors[randomIndex];
        }

        public string GetColor()
        {
            return _color;
        }
    }
}
