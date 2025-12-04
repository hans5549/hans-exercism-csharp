namespace Examer.Extension
{
    public static class LogAnalysis
    {
        // TODO: define the 'SubstringAfter()' extension method on the `string` type
        public static string SubstringAfter(this string str, string text)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            int index = str.IndexOf(text);
            if (index == -1 || index + text.Length >= str.Length)
                return string.Empty;

            return str.Split(text)[1];
        }

        // TODO: define the 'SubstringBetween()' extension method on the `string` type
        public static string SubstringBetween(this string str, string start, string end)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            int indexStartStr = str.IndexOf(start);
            if (indexStartStr == -1) return string.Empty;
            int indexEndStr = str.IndexOf(end);
            if (indexEndStr == -1) return string.Empty;

            return str.Substring(indexStartStr + start.Length, indexEndStr - indexStartStr - start.Length).Trim();
        }

        // TODO: define the 'Message()' extension method on the `string` type
        public static string Message(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            return str.SubstringAfter(": ").Trim();
        }

        // TODO: define the 'LogLevel()' extension method on the `string` type
        public static string LogLevel(this string str)
        {
            return str.SubstringBetween("[", "]");
        }
    }
}
