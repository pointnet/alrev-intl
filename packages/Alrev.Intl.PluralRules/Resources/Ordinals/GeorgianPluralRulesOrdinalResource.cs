//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Script: ./scripts/cldr-plural-rules.csx
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using System;
using System.Linq;

namespace Alrev.Intl.PluralRules.Resources.Ordinals
{
    /// <summary>
    /// Ordinal <see cref="IPluralRulesResource"/> for 'Georgian' [ka]
    /// </summary>
    /// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#ka"/>
    public class GeorgianPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        /// <summary>
        /// The <see cref="IPluralRulesResource"/> locale
        /// </summary>
        public string Locale { get; } = "ka";

        /// <summary>
        /// The <see cref="IPluralRulesResource"/> type
        /// </summary>
        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        /// <summary>
        /// Evaluates a <see cref="IPluralRulesContext"/> against the 'Georgian' [ka] Ordinal <see cref="IPluralRulesResource"/>
        /// </summary>
        /// <param name="context">A <see cref="IPluralRulesContext"/></param>
        /// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
        /// <remarks>
        /// one - i = 1
        /// many - i = 0 or i % 100 = 2..20,40,60,80
        /// other - 
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException("IPluralRulesContext must not be null", nameof(context)),
            IPluralRulesContext prc when prc.i == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.i == 0 || (prc.i % 100).In(new int[] { 40, 60, 80 }.Concat(Enumerable.Range(2, 19)).Select<int, double>(i => i).ToArray()) => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}