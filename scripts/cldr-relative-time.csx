#r "nuget: McMaster.Extensions.CommandLineUtils, 3.1.0"
#r "nuget: Handlebars.Net, 2.0.7"
#load "./shared/base-command.csx"
#load "./shared/extensions.csx"

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public record RelativeTime(
    string Type,
    string DisplayName,
    string Previous,
    string Current,
    string Next,
    RelativeTimeCount Past,
    RelativeTimeCount Future);

public record RelativeTimeCount(string One, string Other);

HandlebarsDotNet.Handlebars.RegisterTemplate("resource", File.ReadAllText("./handlebar/relative-time-resource.hbs"));

public class CldrRelativeTime : BaseCommand
{
    private const string SCRIPT = "./scripts/cldr-relative-time.csx";

    [McMaster.Extensions.CommandLineUtils.Option("-na | --namespace", "Namespace of the resources", McMaster.Extensions.CommandLineUtils.CommandOptionType.SingleValue)]
    [System.ComponentModel.DataAnnotations.Required]
    public string Namespace { get; } = @"";

    public static int Execute(string[] args) => McMaster.Extensions.CommandLineUtils.CommandLineApplication.Execute<CldrRelativeTime>(args);

    private HandlebarsDotNet.HandlebarsTemplate<object, object> CultureTemplate { get; } = HandlebarsDotNet.Handlebars.Compile(File.ReadAllText("./handlebar/relative-time-resource-set.hbs"));
    private HandlebarsDotNet.HandlebarsTemplate<object, object> LocalizerTemplate { get; } = HandlebarsDotNet.Handlebars.Compile(File.ReadAllText("./handlebar/relative-time-localizer.hbs"));

    public void OnExecute()
    {
        this.LogHeader(SCRIPT);
        if (!this.EnsureNodeModules()) return;
        if (!this.EnsureNodeModulesPackage("cldr-dates-full")) return;
        this.CreateOrEmptyDirectory("Resources");
        this.CreateOrEmptyDirectory("Globalization");
        this.ProcessCultures();
    }

    protected void ProcessCultures()
    {
        this.LogInfo($"Processing {this.Cultures.Length} cultures from CultureInfo.GetCultures(CultureTypes.AllCultures)");
        Dictionary<string, string> cultures = new Dictionary<string, string>();
        foreach (CultureInfo culture in this.Cultures)
        {
            bool processed = this.ProcessCulture(culture);
            if (processed)
            {
                cultures.Add(culture.Name, culture.EnglishName.ToValidClassName());
            }
        }
        this.GenerateLocalizer(cultures);
        this.LogSuccess($"Processing {this.Cultures.Length} cultures done");
        this.LogSuccess($"  - {cultures.Count} cultures generated");
        this.LogWarning($"  - {this.Cultures.Length - cultures.Count} cultures ignored");
    }

    protected bool ProcessCulture(CultureInfo culture)
    {
        this.LogInfo($"Processing culture '{culture.Name}' - {culture.EnglishName}");
        if (!Directory.Exists(Path.Combine(this.NodeModulePath, "cldr-dates-full", "main", culture.Name)))
        {
            return false;
        }
        string[] prefixes = new string[] { "era", "year", "quarter", "month", "week", "weekOfMonth", "day", "dayOfYear", "weekday", "weekdayOfMonth", "sun", "mon", "tue", "wed", "thu", "fri", "sat", "dayperiod", "hour", "minute", "second", "zone" };
        string[] suffixes = new string[] { "", "-short", "-narrow" };
        Dictionary<string, Dictionary<string, RelativeTime>> relativeTimes = new Dictionary<string, Dictionary<string, RelativeTime>>();
        using System.Text.Json.JsonDocument resource = this.LoadJsonResource("cldr-dates-full", "main", culture.Name, "dateFields.json");
        System.Text.Json.JsonProperty language = resource.RootElement.GetProperty("main").EnumerateObject().First();
        foreach (string prefix in prefixes)
        {
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
                    "-narrow" => "narrow",
                    "-short" => "short",
                    _ => "long"
                }, this.ProcessRelativeTime(key, suffix switch
                {
                    "-narrow" => "RelativeTimeTypeValues.Narrow",
                    "-short" => "RelativeTimeTypeValues.Short",
                    _ => "RelativeTimeTypeValues.Long"
                }, field));
            }
            relativeTimes.Add(prefix switch
            {
                "weekOfMonth" => "WeekOfMonth",
                "dayOfYear" => "DayOfYear",
                "weekdayOfMonth" => "WeekdayOfMonth",
                "sun" => "Sunday",
                "mon" => "Monday",
                "tue" => "Tuesday",
                "wed" => "Wednesday",
                "thu" => "Thursday",
                "fri" => "Friday",
                "sat" => "Saturday",
                "dayperiod" => "DayPeriod",
                _ => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(prefix)
            }, styles);
        }
        this.GenerateCulture(culture, relativeTimes);
        return true;
    }

    protected RelativeTime ProcessRelativeTime(string key, string type, System.Text.Json.JsonElement field)
    {
        string[] keys = field.EnumerateObject().Select(p => p.Name).ToArray();
        string displayName = keys.Contains("displayName") ? field.GetProperty("displayName").GetString() : null;
        string current = keys.Contains("relative-type-0") ? field.GetProperty("relative-type-0").GetString() : null;
        string next = keys.Contains("relative-type-1") ? field.GetProperty("relative-type-1").GetString() : null;
        string previous = keys.Contains("relative-type--1") ? field.GetProperty("relative-type--1").GetString() : null;
        System.Text.Json.JsonElement? past = keys.Contains("relativeTime-type-past") ? field.GetProperty("relativeTime-type-past") : null;
        System.Text.Json.JsonElement? future = keys.Contains("relativeTime-type-future") ? field.GetProperty("relativeTime-type-future") : null;
        return new RelativeTime(
            type,
            displayName,
            previous,
            current,
            next,
            this.ProcessRelativeTimeCount(past),
            this.ProcessRelativeTimeCount(future));
    }

    protected RelativeTimeCount ProcessRelativeTimeCount(System.Text.Json.JsonElement? field)
    {
        if (!field.HasValue) return null;
        string[] keys = field.Value.EnumerateObject().Select(p => p.Name).ToArray();
        string one = keys.Contains("relativeTimePattern-count-one")
            ? field.Value.GetProperty("relativeTimePattern-count-one").GetString()
            : null;
        string other = keys.Contains("relativeTimePattern-count-other")
            ? field.Value.GetProperty("relativeTimePattern-count-other").GetString()
            : null;
        return new RelativeTimeCount(one, other);
    }

    protected void GenerateCulture(CultureInfo culture, Dictionary<string, Dictionary<string, RelativeTime>> relativeTimes)
    {
        string csharp = this.CultureTemplate(new
        {
            script = SCRIPT,
            locale = culture.Name,
            @namespace = $"{this.Namespace}.Resources",
            classPrefix = culture.EnglishName.ToValidClassName(),
            relativeTimes = relativeTimes
        });
        File.WriteAllText(Path.Combine(this.OutputPath, "Resources", $"{culture.EnglishName.ToValidClassName()}RelativeTimeResourceSet.cs"), csharp);
    }

    protected void GenerateLocalizer(Dictionary<string, string> cultures)
    {
        string csharp = this.LocalizerTemplate(new
        {
            script = SCRIPT,
            @namespace = $"{this.Namespace}.Globalization",
            cultures = cultures
        });
        File.WriteAllText(Path.Combine(this.OutputPath, "Globalization", "RelativeTimeLocalizer.cs"), csharp);
    }
}

CldrRelativeTime.Execute(Args.ToArray());