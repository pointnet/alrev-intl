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

namespace Alrev.Intl.PluralRules.Resources.Cardinals
{
	/// <summary>
	/// Cardinal <see cref="IPluralRulesResource"/> for 'Macedonian' [mk]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#mk"/>
    public class MacedonianPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        /// <summary>
        /// The <see cref="IPluralRulesResource"/> locale
        /// </summary>
        public string Locale { get; } = "mk";

        /// <summary>
        /// The <see cref="IPluralRulesResource"/> type
        /// </summary>
        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

		/// <summary>
  		/// Evaluates a <see cref="IPluralRulesContext"/> against the 'Macedonian' [mk] Cardinal <see cref="IPluralRulesResource"/>
  		/// </summary>
  		/// <param name="context">A <see cref="IPluralRulesContext"/></param>
  		/// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
  		/// <remarks>
        /// one - v = 0 and i % 10 = 1 and i % 100 != 11 or f % 10 = 1 and f % 100 != 11
        /// other - 
  		/// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when prc.v == 0 && prc.i % 10 == 1 && prc.i % 100 != 11 || prc.f % 10 == 1 && prc.f % 100 != 11 => PluralRulesValues.One,
            _ => PluralRulesValues.Other
        };
    }
}