namespace Alrev.Intl.Abstractions.PluralRules
{
    /// <summary>
    /// Defines a Plural Rules resource.
    /// </summary>
    /// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html"/>
    public interface IPluralRulesResource : IIntlResource
    {
        /// <summary>
        /// Evaluates a <see cref="IPluralRulesContext"/> against a specific <see cref="IPluralRulesResource"/>
        /// </summary>
        /// <param name="context">A <see cref="IPluralRulesContext"/></param>
        /// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        PluralRulesValues Evaluate(IPluralRulesContext context);
    }
}
