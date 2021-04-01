using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static string ToValidClassName(this string input)
{
    string onlyLetters = Regex.Replace(input, @"[ (),-.&\[\]ʼ’]", string.Empty);
    string normalized = onlyLetters.Normalize(NormalizationForm.FormD);
    string replaced = new string(normalized.Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray());
    return replaced.FirstCharToUpper();
}

public static string FirstCharToUpper(this string input) => input switch
{
    null => throw new ArgumentNullException(nameof(input)),
    "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
    _ => input.First().ToString().ToUpper() + input.Substring(1)
};