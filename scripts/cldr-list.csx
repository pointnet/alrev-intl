#r "nuget: McMaster.Extensions.CommandLineUtils, 3.1.0"
#r "nuget: Handlebars.Net, 2.0.7"
#load "./shared/base-command.csx"
#load "./shared/extensions.csx"

using System.Collections.Generic;
using System.Globalization;
using System.IO;

public class CldrList : BaseCommand
{
    protected const string SCRIPT = "./scripts/cldr-list.csx";

    public static int Execute(string[] args) => McMaster.Extensions.CommandLineUtils.CommandLineApplication.Execute<CldrList>(args);

    private HandlebarsDotNet.HandlebarsTemplate<object, object> CultureTemplate { get; } = HandlebarsDotNet.Handlebars.Compile(File.ReadAllText("./handlebar/list/list-resource.hbs"));

    public void OnExecute()
    {
        this.LogHeader(SCRIPT);
        if (!this.EnsureNodeModules()) return;
        if (!this.EnsureNodeModulesPackage("cldr-misc-full")) return;
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
                cultures.Add(culture.Name.ToLowerInvariant(), $"{culture.Name.ToValidClassName()}List");
            }
        }
        this.GenerateLocalizer(
            SCRIPT,
            "Alrev.Intl.List.Globalization",
            "List",
            "Alrev.Intl.Abstractions.List",
            "IListResource",
            "Alrev.Intl.List.Resources",
            cultures,
            Path.Combine(this.OutputPath, "Globalization"));
        this.GenerateLocalizerTests(
            SCRIPT,
            "Alrev.Intl.List.Tests.Globalization",
            "List",
            "Alrev.Intl.List.Tests.Fixtures",
            "Alrev.Intl.Abstractions.List",
            "IListResource",
            cultures,
            Path.Combine(this.OutputPath, "..", "..", "tests", "Alrev.Intl.List.Tests", "Globalization"));
        this.GenerateLocalizerFixture(
            SCRIPT,
            "Alrev.Intl.List.Tests.Fixtures",
            "Alrev.Intl.Abstractions.List",
            "IListResource",
            "Alrev.Intl.List.Globalization",
            "List",
            Path.Combine(this.OutputPath, "..", "..", "tests", "Alrev.Intl.List.Tests", "Fixtures"));
        this.GenerateLocalizerCollectionDefinition(
            SCRIPT,
            "Alrev.Intl.List.Tests.Fixtures",
            "List",
            Path.Combine(this.OutputPath, "..", "..", "tests", "Alrev.Intl.List.Tests", "Fixtures"));
        this.LogSuccess($"Processing {this.Cultures.Length} cultures done");
        this.LogSuccess($"  - {cultures.Count} cultures generated");
        this.LogWarning($"  - {this.Cultures.Length - cultures.Count} cultures ignored");
    }

    protected bool ProcessCulture(CultureInfo culture)
    {
        if (!Directory.Exists(Path.Combine(this.NodeModulePath, "cldr-misc-full", "main", culture.Name)))
        {
            return false;
        }
        string[] prefixes = new string[] { "standard", "or", "unit" };
        string[] suffixes = new string[] { "", "-short", "-narrow" };
        using System.Text.Json.JsonDocument resource = this.LoadJsonResource("cldr-misc-full", "main", culture.Name, "listPatterns.json");
        System.Text.Json.JsonProperty language = resource.RootElement.GetProperty("main").EnumerateObject().First();
        Dictionary<string, Dictionary<string, Dictionary<string, string>>> resources = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
        foreach (string prefix in prefixes)
        {
            Dictionary<string, Dictionary<string, string>> styles = new Dictionary<string, Dictionary<string, string>>();
            foreach (string suffix in suffixes)
            {
                string key = $"listPattern-type-{prefix}{suffix}";
                System.Text.Json.JsonElement field = resource.RootElement
                    .GetProperty("main")
                    .GetProperty(language.Name)
                    .GetProperty("listPatterns")
                    .GetProperty(key);
                styles.Add(
                    suffix switch
                    {
                        "-narrow" => "IntlStyleValues.Narrow",
                        "-short" => "IntlStyleValues.Short",
                        _ => "IntlStyleValues.Long"
                    },
                    new Dictionary<string, string>()
                    {
                        { "ListPartValues.Start", field.GetProperty("start").GetString() },
                        { "ListPartValues.Middle", field.GetProperty("middle").GetString() },
                        { "ListPartValues.End", field.GetProperty("end").GetString() },
                        { "ListPartValues.Pair", field.GetProperty("2").GetString() }
                    });
            }
            resources.Add(prefix switch
            {
                "unit" => "ListTypeValues.Unit",
                "or" => "ListTypeValues.Disjunction",
                _ => "ListTypeValues.Conjunction"
            }, styles);
        }
        this.GenerateCulture(culture, resources);
        return true;
    }

    protected void GenerateCulture(CultureInfo culture, Dictionary<string, Dictionary<string, Dictionary<string, string>>> resources)
    {
        string csharp = this.CultureTemplate(new
        {
            script = SCRIPT,
            locale = culture.Name.ToLowerInvariant(),
            englishName = culture.EnglishName,
            @namespace = $"{this.Namespace}.Resources",
            className = $"{culture.Name.ToValidClassName()}List",
            resources = resources
        });
        File.WriteAllText(Path.Combine(this.OutputPath, "Resources", $"{culture.Name.ToValidClassName()}ListResource.intl.cs"), csharp);
    }
}

CldrList.Execute(Args.ToArray());