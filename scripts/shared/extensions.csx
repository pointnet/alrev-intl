#r "nuget: Handlebars.Net, 2.0.7"

using System;
using System.Globalization;
using System.Linq;

HandlebarsDotNet.Handlebars.RegisterTemplate("autoGenerated", System.IO.File.ReadAllText("./handlebar/auto-generated.hbs"));

HandlebarsDotNet.Handlebars.RegisterHelper("notLast", (writer, context, args) =>
{
    System.Collections.IDictionary dictionary = args[0] as System.Collections.IDictionary;
    int index = (int)args[1];
    string separator = (string)args[2];
    if (dictionary.Count - 1 != index)
    {
        writer.Write(separator);
    }
});

public static string ToValidClassName(this string input)
{
    return string.Join("", input.ToLowerInvariant().Split('-').Select(s => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(s)));
}

public static string FirstCharToUpper(this string input) => input switch
{
    null => throw new ArgumentNullException(nameof(input)),
    "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
    _ => input.First().ToString().ToUpper() + input.Substring(1)
};