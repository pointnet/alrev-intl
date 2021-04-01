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
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#be
    public class BelarusianPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "be";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        // few - n % 10 = 2,3 and n % 100 != 12,13
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when (prc.n % 10).In(2, 3) && (prc.n % 100).NotIn(12, 13) => PluralRulesValues.Few,
            _ => PluralRulesValues.Other
        };
    }
}