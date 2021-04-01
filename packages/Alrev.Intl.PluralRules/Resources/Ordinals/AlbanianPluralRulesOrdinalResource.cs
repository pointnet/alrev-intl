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
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#sq
    public class AlbanianPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "sq";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        // one - n = 1
        // many - n % 10 = 4 and n % 100 != 14
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when prc.n == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.n % 10 == 4 && prc.n % 100 != 14 => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}