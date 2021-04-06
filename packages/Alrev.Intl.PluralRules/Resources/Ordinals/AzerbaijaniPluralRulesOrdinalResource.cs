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
    /// Ordinal <see cref="IPluralRulesResource"/> for 'Azerbaijani' [az]
    /// </summary>
    /// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#az"/>
    public class AzerbaijaniPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        /// <summary>
        /// The <see cref="IPluralRulesResource"/> locale
        /// </summary>
        public string Locale { get; } = "az";

        /// <summary>
        /// The <see cref="IPluralRulesResource"/> type
        /// </summary>
        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        /// <summary>
        /// Evaluates a <see cref="IPluralRulesContext"/> against the 'Azerbaijani' [az] Ordinal <see cref="IPluralRulesResource"/>
        /// </summary>
        /// <param name="context">A <see cref="IPluralRulesContext"/></param>
        /// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
        /// <remarks>
        /// one - i % 10 = 1,2,5,7,8 or i % 100 = 20,50,70,80
        /// few - i % 10 = 3,4 or i % 1000 = 100,200,300,400,500,600,700,800,900
        /// many - i = 0 or i % 10 = 6 or i % 100 = 40,60,90
        /// other - 
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when (prc.i % 10).In(1, 2, 5, 7, 8) || (prc.i % 100).In(20, 50, 70, 80) => PluralRulesValues.One,
            IPluralRulesContext prc when (prc.i % 10).In(3, 4) || (prc.i % 1000).In(100, 200, 300, 400, 500, 600, 700, 800, 900) => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.i == 0 || prc.i % 10 == 6 || (prc.i % 100).In(40, 60, 90) => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}