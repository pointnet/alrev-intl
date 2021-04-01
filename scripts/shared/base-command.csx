#r "nuget: McMaster.Extensions.CommandLineUtils, 3.1.0"

using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

[McMaster.Extensions.CommandLineUtils.HelpOption("--script-help")]
public abstract class BaseCommand
{
    [McMaster.Extensions.CommandLineUtils.Argument(0, "output-path", "Relative path to csproj directory where files will be generated")]
    [McMaster.Extensions.CommandLineUtils.DirectoryExists]
    [System.ComponentModel.DataAnnotations.Required]
    public string OutputPath { get; }

    [McMaster.Extensions.CommandLineUtils.Option("-nm | --node-modules", "Relative path to 'node_modules' folder", McMaster.Extensions.CommandLineUtils.CommandOptionType.SingleValue)]
    [McMaster.Extensions.CommandLineUtils.DirectoryExists]
    public string NodeModulePath { get; } = @".\node_modules";

    [McMaster.Extensions.CommandLineUtils.Option("-na | --namespace", "Namespace of the resources", McMaster.Extensions.CommandLineUtils.CommandOptionType.SingleValue)]
    [System.ComponentModel.DataAnnotations.Required]
    public string Namespace { get; } = @"";

    protected CultureInfo[] Cultures { get; } = CultureInfo.GetCultures(CultureTypes.AllCultures).Where(c => !string.IsNullOrWhiteSpace(c.Name)).ToArray();

    protected void Log(string color, string message)
    {
        Console.WriteLine($"\u001b[90m[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] - \u001b[0m\u001b[{color}m{message}\u001b[0m");
    }
    protected void LogError(string message) => this.Log("31", message);
    protected void LogSuccess(string message) => this.Log("32", message);
    protected void LogWarning(string message) => this.Log("33", message);
    protected void LogInfo(string message) => this.Log("36", message);
    protected void LogHeader(string script)
    {
        this.Log("37", "ALREV-INTL-GENERATORS");
        this.Log("37", $"Starting script: {script}");
    }

    protected bool EnsureNodeModules()
    {
        if (!Directory.Exists(this.NodeModulePath))
        {
            this.LogError($"The directory '{this.NodeModulePath}' does not exist");
            return false;
        }
        return true;
    }

    protected bool EnsureNodeModulesPackage(string package)
    {
        if (!Directory.Exists(Path.Combine(this.NodeModulePath, package)))
        {
            this.LogError($"The package '{package}' is not installed");
            this.LogError($"Please execute 'npm i -D {package}' in the package.json directory");
            return false;
        }
        return true;
    }

    protected void CreateOrEmptyDirectory(params string[] paths)
    {
        string path = Path.Combine(new string[] { this.OutputPath }.Concat(paths).ToArray());
        if (!Directory.Exists(path))
        {
            this.LogInfo($"Creating directory '{path}'");
            _ = Directory.CreateDirectory(path);
            return;
        }
        DirectoryInfo di = new DirectoryInfo(path);
        FileInfo[] files = di.GetFiles();
        if (files.Length > 0)
        {
            this.LogInfo($"Deleting {files.Length} files from directory '{path}'");
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
        }
    }

    protected System.Text.Json.JsonDocument LoadJsonResource(params string[] paths)
    {
        string path = Path.Combine(new string[] { this.NodeModulePath }.Concat(paths).ToArray());
        string json = File.ReadAllText(path);
        System.Text.Json.JsonDocument resource = System.Text.Json.JsonDocument.Parse(json);
        return resource;
    }
}