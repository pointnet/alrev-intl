namespace Alrev.Intl.Abstractions.PluralRules
{
    public interface IPluralRulesContext
    {
        string input { get; }
        double n { get; }
        int i { get; }
        int v { get; }
        int w { get; }
        int f { get; }
        int t { get; }
        int e { get; }
        int c { get; }
    }
}
