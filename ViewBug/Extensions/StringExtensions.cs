using System.Text.RegularExpressions;

namespace ViewBug.Extensions
{
    public static class StringExtensions
    {
        public static string ToSnakeCase(this string input, bool lower = true)
        {
            if (string.IsNullOrEmpty(input)) { return input; }

            var startUnderscores = Regex.Match(input, @"^_+");

            string snakeCase = startUnderscores + Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2");

            if (lower)
                snakeCase = snakeCase.ToLower();

            return snakeCase;
        }
    }
}
