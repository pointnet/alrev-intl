namespace Alrev.Intl.Abstractions.PluralRules
{
    /// <summary>
    ///   Interface of a Plural Rule resource.
    /// </summary>
    /// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html"/>
    public interface IPluralRulesResource
    {
        /// <summary>
        /// The <see cref="IPluralRulesResource"/> type
        /// </summary>
        PluralRulesTypeValues PluralRulesType { get; }

        /// <summary>
        /// Evaluates a <see cref="IPluralRulesContext"/> against a specific <see cref="IPluralRulesResource"/>
        /// </summary>
        /// <param name="context">A <see cref="IPluralRulesContext"/></param>
        /// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
        /// <exception cref="ArgumentNullException"></exception>
        PluralRulesValues Evaluate(IPluralRulesContext context);
    }
}
