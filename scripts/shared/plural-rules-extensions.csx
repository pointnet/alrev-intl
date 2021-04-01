using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static string ToCsharp(this string input)
{
    string equals = input.Replace(" = ", " == ");
    string context = Regex.Replace(equals, "([nivwftec] )", "prc.$1");
    string relations = context.ReplaceRelations();
    string ranges = relations.ReplaceRanges();
    string operators = ranges.Replace(" or ", " || ").Replace(" and ", " && ");
    return operators;
}

public static string ReplaceRelations(this string input)
{
    if (!input.Contains(",")) return input;
    return Regex
        .Matches(input, "(^|r |d )(?<left>prc.[nivwftec][^!=]+)(?<operator>[!=]=)(?<right>[^ao]+)")
        .Cast<Match>()
        .Aggregate<Match, string>(input, (acc, current) =>
        {
            string left = current.Groups["left"].Value;
            string @operator = current.Groups["operator"].Value;
            string right = current.Groups["right"].Value;
            if (!right.Contains(",")) return acc;
            if (right.Contains(".."))
            {
                return acc.ReplaceRelationsWithBetween(left, @operator, right);
            }
            string trimmed = left.Trim();
            string original = $"{trimmed} {@operator} {right.Trim()}";
            string replacement = $"{(trimmed.Length == 5 ? trimmed : $"({trimmed})")}.{(@operator == " != " ? "Not" : "")}In({right.Trim().Replace(",", ", ")})";
            return acc.Replace(original, replacement);
        });
}

public static string ReplaceRelationsWithBetween(this string input, string left, string @operator, string right)
{
    (List<string> initialization, List<string> enumerables) = right
        .Trim()
        .Split(",")
        .Select(v => v.ToEnumerableRange())
        .Aggregate<string, (List<string> Initialization, List<string> Enumerables)>((new(), new()), (acc, current) =>
        {
            if (current.StartsWith(".Concat")) acc.Enumerables.Add(current);
            else acc.Initialization.Add(current);
            return acc;
        });
    string start = initialization.Count > 0
        ? $"new int[] {{ {string.Join(", ", initialization)} }}"
        : "Array.Empty<int>()";
    string trimmedLeft = left.Trim();
    string trimmedRight = $"{start}{string.Join("", enumerables)}.Cast<double>().ToArray()";
    string original = $"{trimmedLeft} {@operator} {right.Trim()}";
    string replacement = $"{(trimmedLeft.Length == 5 ? trimmedLeft : $"({ trimmedLeft})")}.{(@operator == " != " ? "Not" : "")}In({trimmedRight})";
    if (trimmedLeft == "prc.n")
    {
        return input.Replace(
          original,
          replacement.Replace("prc.n", "prc.n == prc.i && prc.n")
        );
    }
    return input.Replace(original, replacement);
}

public static string ToEnumerableRange(this string input)
{
    if (!input.Contains("..")) return input;
    int[] limits = input.Split("..").Select(x => int.Parse(x)).ToArray();
    int start = limits[0]; int end = limits[1];
    return $".Concat(Enumerable.Range({start}, {end - start + 1}))";
}

public static string ReplaceRanges(this string input)
{
    if (!input.Contains("..")) return input;
    return Regex
        .Matches(input, "(^|r |d )(?<left>[prc.nivwftec][^!=]+)(?<operator>[!=]=)(?<right>[^ao]+)")
        .Cast<Match>()
        .Aggregate<Match, string>(input, (acc, current) =>
        {
            string left = current.Groups["left"].Value;
            string @operator = current.Groups["operator"].Value;
            string right = current.Groups["right"].Value;
            if (!right.Contains("..")) return acc;
            string trimmed = left.Trim();
            string original = $"{trimmed} {@operator} {right.Trim()}";
            string replacement = $"{(trimmed.Length == 5 ? trimmed : $"({trimmed})")}.{(@operator == " != " ? "Not" : "")}Between({right.Trim().Replace("..", ", ")})";
            if (trimmed == "prc.n")
            {
                return acc.Replace(
                  original,
                  replacement.Replace("prc.n", "prc.n == prc.i && prc.n")
                );
            }
            return acc.Replace(original, replacement);
        });
}