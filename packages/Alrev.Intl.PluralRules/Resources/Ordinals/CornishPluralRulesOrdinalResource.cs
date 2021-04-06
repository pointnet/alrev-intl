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
    /// Ordinal <see cref="IPluralRulesResource"/> for 'Cornish' [kw]
    /// </summary>
    /// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#kw"/>
    public class CornishPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        /// <summary>
        /// The <see cref="IPluralRulesResource"/> locale
        /// </summary>
        public string Locale { get; } = "kw";

        /// <summary>
        /// The <see cref="IPluralRulesResource"/> type
        /// </summary>
        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        /// <summary>
        /// Evaluates a <see cref="IPluralRulesContext"/> against the 'Cornish' [kw] Ordinal <see cref="IPluralRulesResource"/>
        /// </summary>
        /// <param name="context">A <see cref="IPluralRulesContext"/></param>
        /// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
        /// <remarks>
        /// one - n = 1..4 or n % 100 = 1..4,21..24,41..44,61..64,81..84
        /// many - n = 5 or n % 100 = 5
        /// other - 
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when prc.n == prc.i && prc.n.Between(1, 4) || (prc.n % 100).In(Array.Empty<int>().Concat(Enumerable.Range(1, 4)).Concat(Enumerable.Range(21, 4)).Concat(Enumerable.Range(41, 4)).Concat(Enumerable.Range(61, 4)).Concat(Enumerable.Range(81, 4)).Select<int, double>(i => i).ToArray()) => PluralRulesValues.One,
            IPluralRulesContext prc when prc.n == 5 || prc.n % 100 == 5 => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}