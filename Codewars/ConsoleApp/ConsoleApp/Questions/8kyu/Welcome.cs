using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Questions._8kyu
{
    public static class Welcome
    {
        public static string Execute(string language)
        {
            Dictionary<string, string> languages = new Dictionary<string, string>();
            languages.Add("english", "Welcome");
            languages.Add("czech", "Vitejte");
            languages.Add("danish", "Velkomst");
            languages.Add("dutch", "Welkom");
            languages.Add("estonian", "Tere tulemast");
            languages.Add("finnish", "Tervetuloa");
            languages.Add("flemish", "Welgekomen");
            languages.Add("french", "Bienvenue");
            languages.Add("german", "Willkommen");
            languages.Add("irish", "Failte");
            languages.Add("italian", "Benvenuto");
            languages.Add("latvian", "Gaidits");
            languages.Add("lithuanian", "Laukiamas");
            languages.Add("polish", "Witamy");
            languages.Add("spanish", "Bienvenido");
            languages.Add("swedish", "Valkommen");
            languages.Add("welsh", "Croeso");

            return languages.Keys.Contains(language) ? languages[language] : languages["english"];
        }
    }
}
