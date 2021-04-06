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
	/// Ordinal <see cref="IPluralRulesResource"/> for 'Gujarati' [gu]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#gu"/>
    public class GujaratiPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        /// <summary>
        /// The <see cref="IPluralRulesResource"/> locale
        /// </summary>
        public string Locale { get; } = "gu";

        /// <summary>
        /// The <see cref="IPluralRulesResource"/> type
        /// </summary>
        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        /// <summary>
        /// Evaluates a <see cref="IPluralRulesContext"/> against the 'Gujarati' [gu] Ordinal <see cref="IPluralRulesResource"/>
        /// </summary>
        /// <param name="context">A <see cref="IPluralRulesContext"/></param>
        /// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
        /// <remarks>
        /// one - n = 1
        /// two - n = 2,3
        /// few - n = 4
        /// many - n = 6
        /// other - 
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when prc.n == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.n.In(2, 3) => PluralRulesValues.Two,
            IPluralRulesContext prc when prc.n == 4 => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.n == 6 => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}