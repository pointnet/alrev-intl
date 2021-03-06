#r "nuget: McMaster.Extensions.CommandLineUtils, 3.1.0"
#r "nuget: Handlebars.Net, 2.0.7"
#load "./shared/base-command.csx"
#load "./shared/extensions.csx"
#load "./shared/plural-rules-extensions.csx"

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

HandlebarsDotNet.Handlebars.RegisterHelper("formatRule", (writer, context, args) =>
{
    string result = args[0] as string;
    string cldr = args[1] as string;
    if (string.IsNullOrWhiteSpace(cldr))
    {
        writer.Write($"_ => PluralRulesValues.{result.FirstCharToUpper()}");
        return;
    }
    writer.Write($"IPluralRulesContext prc when {cldr.ToCsharp()} => PluralRulesValues.{result.FirstCharToUpper()},");
});
HandlebarsDotNet.Handlebars.RegisterHelper("formatPluralValues", (writer, context, args) =>
{
    string content = args[0] as string;
    writer.Write($"PluralRulesValues.{content.FirstCharToUpper()}");
});

public class CldrPluralRules : BaseCommand
{
    private const string SCRIPT = "./scripts/cldr-plural-rules.csx";

    public static int Execute(string[] args) => McMaster.Extensions.CommandLineUtils.CommandLineApplication.Execute<CldrPluralRules>(args);

    private HandlebarsDotNet.HandlebarsTemplate<object, object> CultureTemplate { get; } = HandlebarsDotNet.Handlebars.Compile(File.ReadAllText("./handlebar/plural-rules/plural-rules-resource.hbs"));
    private HandlebarsDotNet.HandlebarsTemplate<object, object> CultureTestsTemplate { get; } = HandlebarsDotNet.Handlebars.Compile(File.ReadAllText("./handlebar/plural-rules/plural-rules-resource-tests.hbs"));

    public void OnExecute()
    {
        this.LogHeader(SCRIPT);
        if (!this.EnsureNodeModules()) return;
        if (!this.EnsureNodeModulesPackage("cldr-core")) return;
        this.CreateOrEmptyDirectory("Resources", "Cardinals");
        this.CreateOrEmptyDirectory("Resources", "Ordinals");
        this.CreateOrEmptyDirectory("Globalization");
        this.CreateOrEmptyDirectory("..", "..", "tests", $"{this.Namespace}.Tests", "Fixtures");
        this.CreateOrEmptyDirectory("..", "..", "tests", $"{this.Namespace}.Tests", "Resources", "Cardinals");
        this.CreateOrEmptyDirectory("..", "..", "tests", $"{this.Namespace}.Tests", "Resources", "Ordinals");
        this.CreateOrEmptyDirectory("..", "..", "tests", $"{this.Namespace}.Tests", "Globalization");
        this.ProcessCultures();
    }

    protected void ProcessCultures()
    {
        this.LogInfo($"Processing {this.Cultures.Length} cultures from CultureInfo.GetCultures(CultureTypes.AllCultures)");
        Dictionary<string, string> ordinals = new Dictionary<string, string>();
        Dictionary<string, string> cardinals = new Dictionary<string, string>();
        foreach (CultureInfo culture in this.Cultures)
        {
            if (this.ProcessPluralRules(culture, "ordinal", "ordinals.json"))
            {
                ordinals.Add(culture.Name.ToLowerInvariant(), $"{culture.Name.ToValidClassName()}PluralRulesOrdinal");
            }
            if (this.ProcessPluralRules(culture, "cardinal", "plurals.json"))
            {
                cardinals.Add(culture.Name.ToLowerInvariant(), $"{culture.Name.ToValidClassName()}PluralRulesCardinal");
            }
        }
        this.GenerateLocalizer(ordinals, "Ordinal");
        this.GenerateLocalizer(cardinals, "Cardinal");
        this.LogSuccess($"Processing {this.Cultures.Length} cultures done");
        this.LogSuccess($"  - {ordinals.Count} cultures ordinals generated");
        this.LogWarning($"  - {this.Cultures.Length - ordinals.Count} cultures ordinals ignored");
        this.LogSuccess($"  - {cardinals.Count} cultures cardinals generated");
        this.LogWarning($"  - {this.Cultures.Length - cardinals.Count} cultures cardinals ignored");
    }

    protected bool ProcessPluralRules(CultureInfo culture, string type, string file)
    {
        using System.Text.Json.JsonDocument resource = this.LoadJsonResource("cldr-core", "supplemental", file);
        string[] keys = resource.RootElement.GetProperty("supplemental").GetProperty($"plurals-type-{type}").EnumerateObject().Select(p => p.Name).ToArray();
        if (!keys.Contains(culture.Name)) return false;
        System.Text.Json.JsonElement element = resource.RootElement.GetProperty("supplemental").GetProperty($"plurals-type-{type}").GetProperty(culture.Name);
        string[] children = element.EnumerateObject().Select(p => p.Name).ToArray();
        Dictionary<string, string> resources = new();
        Dictionary<string, List<string>> examples = new();
        foreach (string key in children)
        {
            string[] cldr = element.GetProperty(key).GetString().Split('@');
            string expression = cldr[0].Trim();
            resources.Add(key.Replace("pluralRule-count-", ""), expression);
            if (cldr.Length > 1)
            {
                examples.Add(
                    key.Replace("pluralRule-count-", ""),
                    cldr.Skip(1)
                        .Select(
                            s => s.Split(" ")
                                .Select(s => s.Trim().TrimEnd(','))
                                .Where(s => !string.IsNullOrEmpty(s))
                                .Where(s => Regex.IsMatch(s, @"^-?[0-9]+(\.[0-9]+)?(~-?[0-9]+(\.[0-9]+)?)?$"))
                                .Select(s => s.Split('~').ToTestableRange())
                                .SelectMany(s => s))
                        .SelectMany(s => s)
                        .ToList());
            }
        }
        if ((culture.Name == "lv" || culture.Name == "prg") && type == "cardinal")
        {
            if (!examples.ContainsKey("zero"))
            {
                examples.Add("zero", new());
            }
            if (!examples.ContainsKey("one"))
            {
                examples.Add("one", new());
            }
            examples["zero"].Add("1.11");
            examples["one"].Add("2.21");
        }
        this.GenerateCulture(culture, type.FirstCharToUpper(), resources, examples);
        return true;
    }

    protected void GenerateCulture(CultureInfo culture, string type, Dictionary<string, string> resources, Dictionary<string, List<string>> examples)
    {
        string csharp = this.CultureTemplate(new
        {
            script = SCRIPT,
            locale = culture.Name.ToLowerInvariant(),
            englishName = culture.EnglishName,
            @namespace = $"{this.Namespace}.Resources.{type}s",
            className = $"{culture.Name.ToValidClassName()}PluralRules{type}",
            pluralType = type,
            resources = resources
        });
        File.WriteAllText(Path.Combine(this.OutputPath, "Resources", $"{type}s", $"{culture.Name.ToValidClassName()}PluralRules{type}Resource.intl.cs"), csharp);
        string tests = this.CultureTestsTemplate(new
        {
            script = SCRIPT,
            locale = culture.Name.ToLowerInvariant(),
            @namespace = $"{this.Namespace}.Tests.Resources.{type}s",
            className = $"{culture.Name.ToValidClassName()}PluralRules{type}",
            fixtureName = $"PluralRules{type}",
            examples = examples
        });
        File.WriteAllText(Path.Combine(this.OutputPath, "..", "..", "tests", $"{this.Namespace}.Tests", "Resources", $"{type}s", $"{culture.Name.ToValidClassName()}PluralRules{type}ResourceTests.intl.cs"), tests);
    }

    protected void GenerateLocalizer(Dictionary<string, string> cultures, string type)
    {
        this.GenerateLocalizer(
            SCRIPT,
            $"Alrev.Intl.PluralRules.Globalization.{type}s",
            $"PluralRules{type}",
            "Alrev.Intl.Abstractions.PluralRules",
            $"IPluralRules{type}Resource",
            $"Alrev.Intl.PluralRules.Resources.{type}s",
            cultures,
            Path.Combine(this.OutputPath, "Globalization"));
        this.GenerateLocalizerTests(
            SCRIPT,
            $"Alrev.Intl.PluralRules.Globalization.{type}s",
            $"PluralRules{type}",
            "Alrev.Intl.PluralRules.Tests.Fixtures",
            "Alrev.Intl.Abstractions.PluralRules",
            $"IPluralRules{type}Resource",
            cultures,
            Path.Combine(this.OutputPath, "..", "..", "tests", "Alrev.Intl.PluralRules.Tests", "Globalization"));
        this.GenerateLocalizerFixture(
            SCRIPT,
            "Alrev.Intl.PluralRules.Tests.Fixtures",
            "Alrev.Intl.Abstractions.PluralRules",
            $"IPluralRules{type}Resource",
            $"Alrev.Intl.PluralRules.Globalization.{type}s",
            $"PluralRules{type}",
            Path.Combine(this.OutputPath, "..", "..", "tests", "Alrev.Intl.PluralRules.Tests", "Fixtures"));
        this.GenerateLocalizerCollectionDefinition(
            SCRIPT,
            "Alrev.Intl.PluralRules.Tests.Fixtures",
            $"PluralRules{type}",
            Path.Combine(this.OutputPath, "..", "..", "tests", "Alrev.Intl.PluralRules.Tests", "Fixtures"));
    }
}

CldrPluralRules.Execute(Args.ToArray());