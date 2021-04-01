namespace Alrev.Intl.Abstractions.PluralRules
{
    public interface IPluralRulesResource
    {
        PluralRulesTypeValues PluralRulesType { get; }
        PluralRulesValues Evaluate(IPluralRulesContext context);
    }
}
