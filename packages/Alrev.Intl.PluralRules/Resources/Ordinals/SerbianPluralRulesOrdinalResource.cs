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
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#sr
    public class SerbianPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "sr";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            _ => PluralRulesValues.Other
        };
    }
}