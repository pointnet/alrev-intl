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
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#sv
    public class SwedishPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "sv";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        // one - n % 10 = 1,2 and n % 100 != 11,12
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when (prc.n % 10).In(1, 2) && (prc.n % 100).NotIn(11, 12) => PluralRulesValues.One,
            _ => PluralRulesValues.Other
        };
    }
}