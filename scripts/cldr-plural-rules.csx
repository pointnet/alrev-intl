#r "nuget: McMaster.Extensions.CommandLineUtils, 3.1.0"
#r "nuget: Handlebars.Net, 2.0.7"
#load "./shared/base-command.csx"
#load "./shared/extensions.csx"
#load "./shared/plural-rules-extensions.csx"

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

HandlebarsDotNet.Handlebars.RegisterHelper("lengthEquals", (writer, options, context, args) =>
{
    if (args[0] is null || args[1] is null)
    {
        options.Inverse(writer, context);
        return;
    }
    Dictionary<string, string> rules = args[0] as Dictionary<string, string>;
    if (rules.Count != (int)args[1])
    {
        options.Inverse(writer, context);
        return;
    }
    options.Template(writer, context);
});
HandlebarsDotNet.Handlebars.RegisterHelper("formatOne", (writer, context, args) =>
{
    Dictionary<string, string> content = args[0] as Dictionary<string, string>;
    writer.Write($"PluralRulesValues.{content.First().Key.FirstCharToUpper()}");
});
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

public class CldrPluralRules : BaseCommand
{
    private const string SCRIPT = "./scripts/cldr-plural-rules.csx";

    public static int Execute(string[] args) => McMaster.Extensions.CommandLineUtils.CommandLineApplication.Execute<CldrPluralRules>(args);

    private HandlebarsDotNet.HandlebarsTemplate<object, object> CultureTemplate { get; } = HandlebarsDotNet.Handlebars.Compile(File.ReadAllText("./handlebar/plural-rules-resource.hbs"));
    private HandlebarsDotNet.HandlebarsTemplate<object, object> LocalizerTemplate { get; } = HandlebarsDotNet.Handlebars.Compile(File.ReadAllText("./handlebar/plural-rules-localizer.hbs"));

    public void OnExecute()
    {
        this.LogHeader(SCRIPT);
        if (!this.EnsureNodeModules()) return;
        if (!this.EnsureNodeModulesPackage("cldr-core")) return;
        this.CreateOrEmptyDirectory("Resources", "Cardinals");
        this.CreateOrEmptyDirectory("Resources", "Ordinals");
        this.CreateOrEmptyDirectory("Globalization");
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
                ordinals.Add(culture.Name, culture.EnglishName.ToValidClassName());
            }
            if (this.ProcessPluralRules(culture, "cardinal", "plurals.json"))
            {
                cardinals.Add(culture.Name, culture.EnglishName.ToValidClassName());
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
        this.LogInfo($"Processing culture {type} '{culture.Name}' - {culture.EnglishName}");
        using System.Text.Json.JsonDocument resource = this.LoadJsonResource("cldr-core", "supplemental", file);
        string[] keys = resource.RootElement.GetProperty("supplemental").GetProperty($"plurals-type-{type}").EnumerateObject().Select(p => p.Name).ToArray();
        if (!keys.Contains(culture.Name)) return false;
        System.Text.Json.JsonElement? element = resource.RootElement.GetProperty("supplemental").GetProperty($"plurals-type-{type}").GetProperty(culture.Name);
        string[] children = element.Value.EnumerateObject().Select(p => p.Name).ToArray();
        Dictionary<string, string> resources = new Dictionary<string, string>();
        foreach (string key in children)
        {
            string cldr = element.Value.GetProperty(key).GetString().Split('@')[0].Trim();
            resources.Add(key.Replace("pluralRule-count-", ""), cldr);
        }
        this.GenerateCulture(culture, type.FirstCharToUpper(), resources);
        return true;
    }

    protected void GenerateCulture(CultureInfo culture, string type, Dictionary<string, string> resources)
    {
        string csharp = this.CultureTemplate(new
        {
            script = SCRIPT,
            locale = culture.Name,
            type = type,
            @namespace = $"{this.Namespace}.Resources.{type}s",
            classPrefix = $"{culture.EnglishName.ToValidClassName()}",
            resources = resources
        });
        File.WriteAllText(Path.Combine(this.OutputPath, "Resources", $"{type}s", $"{culture.EnglishName.ToValidClassName()}PluralRules{type}Resource.cs"), csharp);
    }

    protected void GenerateLocalizer(Dictionary<string, string> cultures, string type)
    {
        string csharp = this.LocalizerTemplate(new
        {
            script = SCRIPT,
            @namespace = $"{this.Namespace}.Globalization",
            type = type,
            cultures = cultures
        });
        File.WriteAllText(Path.Combine(this.OutputPath, "Globalization", $"PluralRules{type}Localizer.cs"), csharp);
    }
}

CldrPluralRules.Execute(Args.ToArray());