#r "nuget: McMaster.Extensions.CommandLineUtils, 3.1.0"
#load "./shared/base-command.csx"

using System.Linq;

public class CldrRelativeTime : BaseCommand
{
    public static int Execute(string[] args) => McMaster.Extensions.CommandLineUtils.CommandLineApplication.Execute<CldrRelativeTime>(args);

    public void OnExecute()
    {
        if (!this.EnsureNodeModules()) return;
        if (!this.EnsureNodeModulesPackage("cldr-dates-full")) return;
    }
}

CldrRelativeTime.Execute(Args.ToArray());