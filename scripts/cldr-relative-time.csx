#r "nuget: McMaster.Extensions.CommandLineUtils, 3.1.0"
#r "nuget: Handlebars.Net, 2.0.7"
#load "./shared/base-command.csx"
#load "./shared/extensions.csx"

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public record RelativeTime(
    string Unit,
    string Type,
    string DisplayName,
    Dictionary<int, string> Current,
    Dictionary<string, string> Past,
    Dictionary<string, string> Future);

HandlebarsDotNet.Handlebars.RegisterHelper("formatDictionary", (writer, context, args) =>
{
    if (args[0] is null)
    {
        writer.Write("null");
        return;
    }
    Dictionary<int, string> content = args[0] as Dictionary<int, string>;
    if (content.Count == 0)
    {
        writer.Write("null");
        return;
    }
    writer.Write($"new Dictionary<int, string> {{ {string.Join(", ", content.Select(kv => $"{{ {kv.Key}, \"{kv.Value}\" }}").ToArray())} }}");
});
HandlebarsDotNet.Handlebars.RegisterHelper("formatPlurals", (writer, context, args) =>
{
    if (args[0] is null)
    {
        writer.Write("null");
        return;
    }
    Dictionary<string, string> pluralRules = args[0] as Dictionary<string, string>;
    if (pluralRules.Count == 0)
    {
        writer.Write("null");
        return;
    }
    writer.Write($"new Dictionary<PluralRulesValues, string> {{ {string.Join(", ", pluralRules.Select(kv => $"{{ PluralRulesValues.{kv.Key.FirstCharToUpper()}, \"{kv.Value}\" }}").ToArray())} }}");
});

public class CldrRelativeTime : BaseCommand
{
    private const string SCRIPT = "./scripts/cldr-relative-time.csx";

    public static int Execute(string[] args) => McMaster.Extensions.CommandLineUtils.CommandLineApplication.Execute<CldrRelativeTime>(args);

    private HandlebarsDotNet.HandlebarsTemplate<object, object> CultureTemplate { get; } = HandlebarsDotNet.Handlebars.Compile(File.ReadAllText("./handlebar/relative-time/relative-time-resource.hbs"));
    private HandlebarsDotNet.HandlebarsTemplate<object, object> CultureTestsTemplate { get; } = HandlebarsDotNet.Handlebars.Compile(File.ReadAllText("./handlebar/relative-time/relative-time-resource-set-tests.hbs"));

    public void OnExecute()
    {
        this.LogHeader(SCRIPT);
        if (!this.EnsureNodeModules()) return;
        if (!this.EnsureNodeModulesPackage("cldr-dates-full")) return;
        this.CreateOrEmptyDirectory("Resources");
        this.CreateOrEmptyDirectory("Globalization");
        this.CreateOrEmptyDirectory("..", "..", "tests", $"{this.Namespace}.Tests", "Fixtures");
        this.CreateOrEmptyDirectory("..", "..", "tests", $"{this.Namespace}.Tests", "Resources");
        this.CreateOrEmptyDirectory("..", "..", "tests", $"{this.Namespace}.Tests", "Globalization");
        this.ProcessCultures();
    }

    protected void ProcessCultures()
    {
        this.LogInfo($"Processing {this.Cultures.Length} cultures from CultureInfo.GetCultures(CultureTypes.AllCultures)");
        Dictionary<string, string> cultures = new Dictionary<string, string>();
        foreach (CultureInfo culture in this.Cultures)
        {
            if (this.ProcessCulture(culture))
            {
                cultures.Add(culture.Name.ToLowerInvariant(), $"{culture.Name.ToValidClassName()}RelativeTime");
            }
        }
        this.GenerateLocalizer(
            SCRIPT,
            "Alrev.Intl.RelativeTime.Globalization",
            "RelativeTime",
            "Alrev.Intl.Abstractions.RelativeTime",
            "IRelativeTimeUnitsResource",
            "Alrev.Intl.RelativeTime.Resources",
            cultures,
            Path.Combine(this.OutputPath, "Globalization"));
        this.GenerateLocalizerTests(
            SCRIPT,
            "Alrev.Intl.RelativeTime.Tests.Globalization",
            "RelativeTime",
            "Alrev.Intl.RelativeTime.Tests.Fixtures",
            "Alrev.Intl.Abstractions.RelativeTime",
            "IRelativeTimeUnitsResource",
            cultures,
            Path.Combine(this.OutputPath, "..", "..", "tests", "Alrev.Intl.RelativeTime.Tests", "Globalization"));
        this.GenerateLocalizerFixture(
            SCRIPT,
            "Alrev.Intl.RelativeTime.Tests.Fixtures",
            "Alrev.Intl.Abstractions.RelativeTime",
            "IRelativeTimeUnitsResource",
            "Alrev.Intl.RelativeTime.Globalization",
            "RelativeTime",
            Path.Combine(this.OutputPath, "..", "..", "tests", "Alrev.Intl.RelativeTime.Tests", "Fixtures"));
        this.GenerateLocalizerCollectionDefinition(
            SCRIPT,
            "Alrev.Intl.RelativeTime.Tests.Fixtures",
            "RelativeTime",
            Path.Combine(this.OutputPath, "..", "..", "tests", "Alrev.Intl.RelativeTime.Tests", "Fixtures"));
        this.LogSuccess($"Processing {this.Cultures.Length} cultures done");
        this.LogSuccess($"  - {cultures.Count} cultures generated");
        this.LogWarning($"  - {this.Cultures.Length - cultures.Count} cultures ignored");
    }

    protected bool ProcessCulture(CultureInfo culture)
    {
        if (!Directory.Exists(Path.Combine(this.NodeModulePath, "cldr-dates-full", "main", culture.Name)))
        {
            return false;
        }
        string[] prefixes = new string[] { "year", "quarter", "month", "week", "day", "sun", "mon", "tue", "wed", "thu", "fri", "sat", "hour", "minute", "second" };
        string[] suffixes = new string[] { "", "-short", "-narrow" };
        Dictionary<string, Dictionary<string, RelativeTime>> relativeTimes = new Dictionary<string, Dictionary<string, RelativeTime>>();
        using System.Text.Json.JsonDocument resource = this.LoadJsonResource("cldr-dates-full", "main", culture.Name, "dateFields.json");
        System.Text.Json.JsonProperty language = resource.RootElement.GetProperty("main").EnumerateObject().First();
        foreach (string prefix in prefixes)
        {
            string titleCasePrefix = prefix switch
            {
                "sun" => "Sunday",
                "mon" => "Monday",
                "tue" => "Tuesday",
                "wed" => "Wednesday",
                "thu" => "Thursday",
                "fri" => "Friday",
                "sat" => "Saturday",
                _ => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(prefix)
            };
            Dictionary<string, RelativeTime> styles = new();
            foreach (string suffix in suffixes)
            {
                string key = $"{prefix}{suffix}";
                System.Text.Json.JsonElement field = resource.RootElement
                    .GetProperty("main")
                    .GetProperty(language.Name)
                    .GetProperty("dates")
                    .GetProperty("fields")
                    .GetProperty(key);

                styles.Add(suffix switch
                {
                    "-narrow" => "Narrow",
                    "-short" => "Short",
                    _ => "Long"
                }, this.ProcessRelativeTime(key, titleCasePrefix, suffix switch
                {
                    "-narrow" => "RelativeTimeStyleValues.Narrow",
                    "-short" => "RelativeTimeStyleValues.Short",
                    _ => "RelativeTimeStyleValues.Long"
                }, field));
            }
            relativeTimes.Add(titleCasePrefix, styles);
        }
        this.GenerateCulture(culture, relativeTimes);
        return true;
    }

    protected RelativeTime ProcessRelativeTime(string key, string titleCasePrefix, string type, System.Text.Json.JsonElement field)
    {
        string[] keys = field.EnumerateObject().Select(p => p.Name).ToArray();
        string displayName = keys.Contains("displayName") ? field.GetProperty("displayName").GetString() : null;
        System.Text.Json.JsonElement? past = keys.Contains("relativeTime-type-past") ? field.GetProperty("relativeTime-type-past") : null;
        System.Text.Json.JsonElement? future = keys.Contains("relativeTime-type-future") ? field.GetProperty("relativeTime-type-future") : null;
        return new RelativeTime(
            $"RelativeTimeUnitValues.{titleCasePrefix}",
            type,
            displayName,
            keys.Where(key => key.StartsWith("relative-type-")).ToDictionary(key => int.Parse(key.Replace("relative-type-", "")), key => field.GetProperty(key).GetString()),
            this.ProcessRelativeTimePlurals(past),
            this.ProcessRelativeTimePlurals(future));
    }

    protected Dictionary<string, string> ProcessRelativeTimePlurals(System.Text.Json.JsonElement? field)
    {
        if (!field.HasValue) return null;
        string[] keys = field.Value.EnumerateObject().Select(p => p.Name).ToArray();
        return keys.ToDictionary(key => key.Replace("relativeTimePattern-count-", ""), key => field.Value.GetProperty(key).GetString());
    }

    protected void GenerateCulture(CultureInfo culture, Dictionary<string, Dictionary<string, RelativeTime>> relativeTimes)
    {
        string csharp = this.CultureTemplate(new
        {
            script = SCRIPT,
            locale = culture.Name.ToLowerInvariant(),
            englishName = culture.EnglishName,
            @namespace = $"{this.Namespace}.Resources",
            className = $"{culture.Name.ToValidClassName()}RelativeTime",
            resources = relativeTimes
        });
        File.WriteAllText(Path.Combine(this.OutputPath, "Resources", $"{culture.Name.ToValidClassName()}RelativeTimeResource.intl.cs"), csharp);

        //string tests = this.CultureTestsTemplate(new
        //{
        //    script = SCRIPT,
        //    locale = culture.Name.ToLowerInvariant(),
        //    @namespace = $"{this.Namespace}.Tests.Resources",
        //    classPrefix = $"{culture.EnglishName.ToValidClassName()}",
        //    relativeTimes = relativeTimes
        //});
        //File.WriteAllText(Path.Combine(this.OutputPath, "..", "..", "tests", $"{this.Namespace}.Tests", "Resources", $"{culture.EnglishName.ToValidClassName()}RelativeTimeResourceSetTests.cs"), tests);
    }

    //protected void GenerateLocalizer(Dictionary<string, string> cultures)
    //{
    //    string csharp = this.LocalizerTemplate(new
    //    {
    //        script = SCRIPT,
    //        @namespace = $"{this.Namespace}.Globalization",
    //        cultures = cultures
    //    });
    //    File.WriteAllText(Path.Combine(this.OutputPath, "Globalization", "RelativeTimeLocalizer.cs"), csharp);
    //    string tests = this.LocalizerTestsTemplate(new
    //    {
    //        script = SCRIPT,
    //        @namespace = this.Namespace,
    //        cultures = cultures
    //    });
    //    File.WriteAllText(Path.Combine(this.OutputPath, "..", "..", "tests", $"{this.Namespace}.Tests", "Globalization", "RelativeTimeLocalizerTests.cs"), tests);
    //}
}

CldrRelativeTime.Execute(Args.ToArray());