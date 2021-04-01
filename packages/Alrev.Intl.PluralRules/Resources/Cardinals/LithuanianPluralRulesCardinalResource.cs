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
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#lt
    public class LithuanianPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "lt";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // one - n % 10 = 1 and n % 100 != 11..19
        // few - n % 10 = 2..9 and n % 100 != 11..19
        // many - f != 0
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when prc.n % 10 == 1 && (prc.n % 100).NotBetween(11, 19) => PluralRulesValues.One,
            IPluralRulesContext prc when (prc.n % 10).Between(2, 9) && (prc.n % 100).NotBetween(11, 19) => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.f != 0 => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}