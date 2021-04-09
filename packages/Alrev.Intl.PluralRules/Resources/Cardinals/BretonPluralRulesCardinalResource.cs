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
    /// Cardinal <see cref="IPluralRulesResource"/> for 'Breton' [br]
    /// </summary>
    /// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#br"/>
    public class BretonPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        /// <summary>
        /// The <see cref="IPluralRulesResource"/> locale
        /// </summary>
        public string Locale { get; } = "br";

        /// <summary>
        /// The <see cref="IPluralRulesResource"/> type
        /// </summary>
        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        /// <summary>
        /// Evaluates a <see cref="IPluralRulesContext"/> against the 'Breton' [br] Cardinal <see cref="IPluralRulesResource"/>
        /// </summary>
        /// <param name="context">An <see cref="IPluralRulesContext"/></param>
        /// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
        /// <remarks>
        /// one - n % 10 = 1 and n % 100 != 11,71,91
        /// two - n % 10 = 2 and n % 100 != 12,72,92
        /// few - n % 10 = 3..4,9 and n % 100 != 10..19,70..79,90..99
        /// many - n != 0 and n % 1000000 = 0
        /// other - 
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context), "IPluralRulesContext must not be null"),
            IPluralRulesContext prc when prc.n % 10 == 1 && (prc.n % 100).NotIn(11, 71, 91) => PluralRulesValues.One,
            IPluralRulesContext prc when prc.n % 10 == 2 && (prc.n % 100).NotIn(12, 72, 92) => PluralRulesValues.Two,
            IPluralRulesContext prc when (prc.n % 10).In(new int[] { 9 }.Concat(Enumerable.Range(3, 2)).Select<int, double>(i => i).ToArray()) && (prc.n % 100).NotIn(Array.Empty<int>().Concat(Enumerable.Range(10, 10)).Concat(Enumerable.Range(70, 10)).Concat(Enumerable.Range(90, 10)).Select<int, double>(i => i).ToArray()) => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.n != 0 && prc.n % 1000000 == 0 => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}