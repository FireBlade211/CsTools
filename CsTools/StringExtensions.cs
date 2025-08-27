using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace FireBlade.CsTools
{
    /// <summary>
    /// Provides extension methods for strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Indicates whether the string is <see langword="null"/> or an empty string (<see cref="string.Empty"/>).
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns><see langword="true"/> if the string is <see langword="null"/> or an empty string; otherwise, <see langword="false"/>.</returns>
       public static bool IsNullOrEmpty(this string? s) => string.IsNullOrEmpty(s);

        /// <summary>
        /// Indicates whether the string is <see langword="null"/>, empty (<see cref="string.Empty"/>), or consists of only whitespace characters.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns><see langword="true"/> if the string is <see langword="null"/> or an empty string, or if the string consists
        /// exclusively of whitespace characters; otherwise, <see langword="false"/>.</returns>
        public static bool IsNullOrWhiteSpace(this string? s) => string.IsNullOrWhiteSpace(s);

        /// <summary>
        /// Indicates whether the string is not <see langword="null"/> or an empty string (<see cref="string.Empty"/>).
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns><see langword="true"/> if the string is not <see langword="null"/> or an empty string; otherwise, <see langword="false"/>.</returns>
        public static bool IsNotNullOrEmpty(this string? s) => !s.IsNullOrEmpty();

        /// <summary>
        /// Indicates whether the string is not <see langword="null"/>, empty (<see cref="string.Empty"/>), or doesn't consist of only whitespace characters.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns><see langword="true"/> if the string is not <see langword="null"/> or an empty string, or if the string doesn't consist
        /// exclusively of whitespace characters; otherwise, <see langword="false"/>.</returns>
        public static bool IsNotNullOrWhiteSpace(this string? s) => !s.IsNullOrWhiteSpace();

        /// <summary>
        /// Tries to parse the string into a number.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="s">The string to try to parse.</param>
        /// <param name="result">The result, if successful.</param>
        /// <returns><see langword="true"/> if the conversion succeeded; otherwise, <see langword="false"/>.</returns>
        public static bool TryParseNumber<TNum>(this string s, [MaybeNullWhen(false)] out TNum result) where TNum : INumber<TNum> => TNum.TryParse(s, null, out result);

        /// <summary>
        /// Tries to parse the string into a number.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="s">The string to try to parse.</param>
        /// <param name="provider">An object that contains culture-specific formatting information.</param>
        /// <param name="result">The result, if successful.</param>
        /// <returns><see langword="true"/> if the conversion succeeded; otherwise, <see langword="false"/>.</returns>
        public static bool TryParseNumber<TNum>(this string s, IFormatProvider provider, [MaybeNullWhen(false)] out TNum result)
            where TNum : INumber<TNum> => TNum.TryParse(s, provider, out result);

        /// <summary>
        /// Tries to parse the string into a number.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="s">The string to try to parse.</param>
        /// <param name="style">A bitwise combination of styles present in the string.</param>
        /// <param name="result">The result, if successful.</param>
        /// <returns><see langword="true"/> if the conversion succeeded; otherwise, <see langword="false"/>.</returns>
        public static bool TryParseNumber<TNum>(this string s, NumberStyles style, [MaybeNullWhen(false)] out TNum result)
            where TNum : INumber<TNum> => TNum.TryParse(s, style, null, out result);

        /// <summary>
        /// Tries to parse the string into a number.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="s">The string to try to parse.</param>
        /// <param name="provider">An object that contains culture-specific formatting information.</param>
        /// <param name="style">A bitwise combination of styles present in the string.</param>
        /// <param name="result">The result, if successful.</param>
        /// <returns><see langword="true"/> if the conversion succeeded; otherwise, <see langword="false"/>.</returns>
        public static bool TryParseNumber<TNum>(this string s, IFormatProvider provider, NumberStyles style, [MaybeNullWhen(false)] out TNum result)
            where TNum : INumber<TNum> => TNum.TryParse(s, style, provider, out result);

        /// <summary>
        /// Parses the string into a number.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="s">The string to parse.</param>
        /// <returns>The string <paramref name="s"/>, converted to a <typeparamref name="TNum"/>.</returns>
        public static TNum ParseNumber<TNum>(this string s) where TNum : INumber<TNum> => TNum.Parse(s, null);
        /// <summary>
        /// Parses the string into a number.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="s">The string to parse.</param>
        /// <param name="provider">An object that provides culture-specific formatting information.</param>
        /// <returns>The string <paramref name="s"/>, converted to a <typeparamref name="TNum"/>.</returns>
        public static TNum ParseNumber<TNum>(this string s, IFormatProvider provider) where TNum : INumber<TNum> => TNum.Parse(s, provider);
        /// <summary>
        /// Parses the string into a number.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="s">The string to parse.</param>
        /// <param name="style">A bitwise combination of styles present in the string.</param>
        /// <returns>The string <paramref name="s"/>, converted to a <typeparamref name="TNum"/>.</returns>
        public static TNum ParseNumber<TNum>(this string s, NumberStyles style) where TNum : INumber<TNum> => TNum.Parse(s, style, null);
        /// <summary>
        /// Parses the string into a number.
        /// </summary>
        /// <typeparam name="TNum">The number type.</typeparam>
        /// <param name="s">The string to parse.</param>
        /// <param name="style">A bitwise combination of styles present in the string.</param>
        /// <param name="provider">An object that provides culture-specific formatting information.</param>
        /// <returns>The string <paramref name="s"/>, converted to a <typeparamref name="TNum"/>.</returns>
        public static TNum ParseNumber<TNum>(this string s, NumberStyles style, IFormatProvider provider) where TNum : INumber<TNum> => TNum.Parse(s, style, provider);

        /// <summary>
        /// Creates a <see cref="string"/> from a <see cref="char"/> collection.
        /// </summary>
        /// <param name="chars">The characters to convert.</param>
        /// <returns>The collection <paramref name="chars"/>, converted to a <see cref="string"/>.</returns>
        public static string GetString(this IEnumerable<char> chars) => new([.. chars]);

        /// <summary>
        /// Gets the casing of a string.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>The casing of the string, or <see cref="StringCasing.Other"/> if a match wasn't found.</returns>
        public static StringCasing GetCasing(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return StringCasing.Other;

            // Helpers
            bool IsUpper() => s.All(c => !char.IsLetter(c) || char.IsUpper(c));
            bool IsLower() => s.All(c => !char.IsLetter(c) || char.IsLower(c));
            bool IsTitle()
            {
                var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                return words.All(w => char.IsUpper(w[0]) && w.Skip(1).All(c => char.IsLower(c)));
            }
            bool IsPascal()
            {
                if (string.IsNullOrEmpty(s)) return false;
                if (!char.IsUpper(s[0])) return false; // PascalCase starts uppercase
                if (s.Contains(' ') || s.Contains('_')) return false; // no separators allowed

                // Check that all subsequent capital letters start valid “words”
                bool previousWasUpper = true; // first letter is upper
                for (int i = 1; i < s.Length; i++)
                {
                    if (char.IsUpper(s[i]))
                    {
                        if (!previousWasUpper) previousWasUpper = true;
                        else return false; // consecutive uppercase letters not allowed
                    }
                    else
                    {
                        previousWasUpper = false;
                    }
                }
                return true;
            }
            bool IsCamel()
            {
                if (string.IsNullOrEmpty(s)) return false;
                if (!char.IsLower(s[0])) return false; // must start lowercase
                if (s.Contains(' ') || s.Contains('_')) return false; // no separators

                // Check if subsequent capital letters are followed by lowercase letters
                int i = 1;
                while (i < s.Length)
                {
                    if (char.IsUpper(s[i]))
                    {
                        // The next letter (if exists) must be lowercase
                        if (i + 1 < s.Length && !char.IsLower(s[i + 1])) return false;
                        i++;
                    }
                    i++;
                }
                return true;
            }
            bool IsSnake()
            {
                // Split by underscore
                var parts = s.Split('_', StringSplitOptions.RemoveEmptyEntries);

                // Snake case requires at least two parts
                if (parts.Length < 2)
                    return false;

                return true;
            }
            bool IsInverse()
            {
                var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (words.Length == 0) return false;

                foreach (var word in words)
                {
                    if (word.Length == 0) continue;

                    // First letter should be lowercase, rest uppercase
                    if (!(char.IsLower(word[0]) && word.Skip(1).All(c => char.IsUpper(c))))
                        return false;
                }

                return true;
            }
            bool IsAlternating() => s.Where(char.IsLetter).Select((c, i) => i % 2 == 0 ? char.IsUpper(c) : char.IsLower(c)).All(x => x);

            if (IsSnake()) return StringCasing.Snake;
            if (IsUpper()) return StringCasing.Upper;
            if (IsLower()) return StringCasing.Lower;
            if (IsTitle()) return StringCasing.Title;
            if (IsPascal()) return StringCasing.Pascal;
            if (IsCamel()) return StringCasing.Camel;
            if (IsInverse()) return StringCasing.Inverse;
            if (IsAlternating()) return StringCasing.Alternating;

            return StringCasing.Other;
        }


        // Helper to split PascalCase or camelCase into words
        private static IEnumerable<string> SplitPascalOrCamel(string s)
        {
            if (string.IsNullOrEmpty(s))
                yield break;

            int wordStart = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    yield return s.Substring(wordStart, i - wordStart);
                    wordStart = i;
                }
            }
            yield return s.Substring(wordStart);
        }

        /// <summary>
        /// Sets the casing of the string.
        /// </summary>
        /// <param name="s">The string to change.</param>
        /// <param name="targetCasing">The new casing.</param>
        /// <returns>The string <paramref name="s"/>, converted to the casing specified in <paramref name="targetCasing"/>.</returns>
        public static string SetCasing(this string s, StringCasing targetCasing)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            var culture = CultureInfo.CurrentCulture;
            var textInfo = culture.TextInfo;

            // Detect the current casing first
            var currentCasing = s.GetCasing();

            // Normalize the string into words
            IEnumerable<string> words = currentCasing switch
            {
                StringCasing.Upper => s.ToLower(culture).Split(' ', StringSplitOptions.RemoveEmptyEntries),
                StringCasing.Lower => s.Split(' ', StringSplitOptions.RemoveEmptyEntries),
                StringCasing.Title => s.Split(' ', StringSplitOptions.RemoveEmptyEntries),
                StringCasing.Pascal => SplitPascalOrCamel(s),
                StringCasing.Camel => SplitPascalOrCamel(s),
                StringCasing.Snake => s.Split('_', StringSplitOptions.RemoveEmptyEntries),
                _ => s.Split(' ', '_', StringSplitOptions.RemoveEmptyEntries),
            };

            // Helper to join words outside the switch
            static string JoinWords(IEnumerable<string> ws, string separator = "") => string.Join(separator, ws);

            // Apply the target casing
            return targetCasing switch
            {
                StringCasing.Upper => s.ToUpper(culture),
                StringCasing.Lower => s.ToLower(culture),
                StringCasing.Title => JoinWords(words.Select(w => textInfo.ToTitleCase(w.ToLower(culture))), " "),
                StringCasing.Pascal => JoinWords(words.Select(w => char.ToUpper(w[0], culture) + w.Substring(1).ToLower(culture))),
                StringCasing.Camel => JoinWords(words.Select((w, i) =>
                    i == 0 ? w.ToLower(culture) : char.ToUpper(w[0], culture) + w.Substring(1).ToLower(culture)), ""),
                StringCasing.Snake => JoinWords(words, "_"),
                StringCasing.Inverse => string.Concat(s.Select(c => char.IsLetter(c)
                    ? (char.IsUpper(c) ? char.ToLower(c, culture) : char.ToUpper(c, culture))
                    : c)),
                StringCasing.AlternatingNormal => string.Concat(s.Select((c, i) => char.IsLetter(c)
                    ? (i % 2 == 0 ? char.ToUpper(c, culture) : char.ToLower(c, culture))
                    : c)),
                StringCasing.AlternatingReverse => string.Concat(s.Select((c, i) => char.IsLetter(c)
                    ? (i % 2 != 0 ? char.ToUpper(c, culture) : char.ToLower(c, culture))
                    : c)),
                StringCasing.Other or StringCasing.Alternating => throw new ArgumentException("The casing cannot be set to Other or Alternating.", nameof(targetCasing)),
                _ => s
            };
        }

        /// <summary>
        /// Determines whether the string reads the same forwards and backwards.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns><see langword="true"/> if the string reads the same backwards; otherwise, <see langword="false"/>.</returns>
        public static bool IsPalindrome(this string s) => s.ToCharArray().Reverse().GetString().Equals(s, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Specifies the casing of a string.
    /// </summary>
    public enum StringCasing
    {
        /// <summary>
        /// The capitalization mode doesn't match any default mode. Cannot be set for <see cref="StringExtensions.SetCasing(string, StringCasing)"/>, but can be retrieved
        /// through <see cref="StringExtensions.GetCasing(string)"/>.
        /// </summary>
        Other,
        /// <summary>
        /// All characters are uppercase.
        /// </summary>
        /// <example>THIS IS AN EXAMPLE.</example>
        Upper,
        /// <summary>
        /// All characters are lowercase.
        /// </summary>
        /// <example>this is an example.</example>
        Lower,
        /// <summary>
        /// The first letter of every word is capitalized and words are seperated by spaces.
        /// </summary>
        /// <example>This Is An Example.</example>
        Title,
        /// <summary>
        /// The first letter of every word is capitalized, but words are NOT seperated by spaces.
        /// </summary>
        /// <example>ThisIsAnExample</example>
        Pascal,
        /// <summary>
        /// The same as <see cref="Pascal"/>, but the first word is not capitalized.
        /// </summary>
        /// <example>thisIsAnExample</example>
        Camel,
        /// <summary>
        /// Words can have any captialization, but they are seperated by underscores.
        /// </summary>
        /// <example>This_is_an_example</example>
        Snake,
        /// <summary>
        /// The inverse of <see cref="Title"/>.
        /// </summary>
        /// <example>tHIS iS aN eXAMPLE.</example>
        Inverse,
        /// <summary>
        /// Every 1st character is uppercase, and every 2nd character is lowercase, or reverse. Cannot be set for <see cref="StringExtensions.SetCasing(string, StringCasing)"/>,
        /// but can be retrieved through <see cref="StringExtensions.GetCasing(string)"/>.
        /// </summary>
        /// <example>ThIs Is An ExAmPlE.</example>
        Alternating,
        /// <summary>
        /// Every 1st character is uppercase, and every 2nd character is lowercase, or reverse. Cannot be retrieved
        /// through <see cref="StringExtensions.GetCasing(string)"/> (see <see cref="Alternating"/> instead).
        /// </summary>
        AlternatingNormal,
        /// <summary>
        /// Every 2nd character is uppercase, and every 1st character is lowercase, or reverse. Cannot be retrieved through
        /// <see cref="StringExtensions.GetCasing(string)"/> (see <see cref="Alternating"/> instead).
        /// </summary>
        AlternatingReverse
    }
}
