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
	/// Cardinal <see cref="IPluralRulesResource"/> for 'Scottish Gaelic' [gd]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#gd"/>
    public class ScottishGaelicPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        /// <summary>
        /// The <see cref="IPluralRulesResource"/> locale
        /// </summary>
        public string Locale { get; } = "gd";

        /// <summary>
        /// The <see cref="IPluralRulesResource"/> type
        /// </summary>
        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

		/// <summary>
  		/// Evaluates a <see cref="IPluralRulesContext"/> against the 'Scottish Gaelic' [gd] Cardinal <see cref="IPluralRulesResource"/>
  		/// </summary>
  		/// <param name="context">A <see cref="IPluralRulesContext"/></param>
  		/// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
  		/// <remarks>
        /// one - n = 1,11
        /// two - n = 2,12
        /// few - n = 3..10,13..19
        /// other - 
  		/// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when prc.n.In(1, 11) => PluralRulesValues.One,
            IPluralRulesContext prc when prc.n.In(2, 12) => PluralRulesValues.Two,
            IPluralRulesContext prc when prc.n == prc.i && prc.n.In(Array.Empty<int>().Concat(Enumerable.Range(3, 8)).Concat(Enumerable.Range(13, 7)).Select<int, double>(i => i).ToArray()) => PluralRulesValues.Few,
            _ => PluralRulesValues.Other
        };
    }
}