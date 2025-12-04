namespace Examer.Extension
{
    public static class Languages
    {
        public static List<string> NewList()
        {
            return [];
        }

        public static List<string> GetExistingLanguages()
        {
            return ["C#", "Clojure", "Elm"];
        }

        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);
            return languages;
        }

        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        public static bool HasLanguage(List<string> languages, string language)
        {
            string? count = languages.FirstOrDefault(l => l == language);
            return count != null;
        }

        public static List<string> ReverseList(List<string> languages)
        {
            if (languages.Count <= 1)
            {
                return languages;
            }

            for (var i = 0; i < languages.Count / 2; i++)
            {
                string temp = languages[i];
                languages[i] = languages[languages.Count - i - 1];
                languages[languages.Count - i - 1] = temp;
            }

            return languages;
        }

        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count == 0) return false;
            if (languages[0] == "C#") return true;
            if (languages[1] == "C#" && (languages.Count == 2 || languages.Count == 3)) return true;

            return false;
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        public static bool IsUnique(List<string> languages)
        {
            if (languages.Count == 0) return false;

            return CountLanguages(languages) == CountLanguages([..languages.Distinct()]);
        }
    }
}
