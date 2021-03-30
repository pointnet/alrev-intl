#r "nuget: McMaster.Extensions.CommandLineUtils, 3.1.0"

using System;
using System.IO;

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

    protected void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    protected void LogWarning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    protected void LogInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    protected bool EnsureModule(string directory, string errorMessage)
    {
        if (!Directory.Exists(directory))
        {
            this.LogError(errorMessage);
            return false;
        }
        return true;
    }
}